using GuerrillaNtp;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

public class FileHeaderHandler
{
    public static byte[] CreateHeader(string fileName, string encKey, long fileLength, long time, out byte[] iv)
    {
        using (SHA256 sha = SHA256.Create())
        {
            byte[] keyHash = sha.ComputeHash(sha.ComputeHash(Encoding.UTF8.GetBytes(encKey)));
            byte[] fileNameBytes = Encoding.UTF8.GetBytes(fileName); // 写入完整文件名
            iv = new byte[16];
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(iv);
            }

            byte[] header = new byte[2 + 2 + 8 + 32 + 8 + 16 + fileNameBytes.Length];

            // Header length (2 bytes)
            BitConverter.GetBytes((short)(header.Length - 2)).CopyTo(header, 0);

            // Version (2 bytes)
            BitConverter.GetBytes((short)3).CopyTo(header, 2); // 版本升级到3

            // File length (8 bytes)
            BitConverter.GetBytes(fileLength).CopyTo(header, 4);

            // Key hash (32 bytes)
            keyHash.CopyTo(header, 12);

            // Time (8 bytes)
            BitConverter.GetBytes(time).CopyTo(header, 44);

            // IV (16 bytes)
            iv.CopyTo(header, 52);

            // File name
            fileNameBytes.CopyTo(header, 68);

            return header;
        }
    }

    public static (short version, long fileLength, byte[] keyHash, long time, byte[] iv, string fileName) ReadHeader(FileStream fs)
    {
        byte[] buffer = new byte[68]; // 固定头部长度
        fs.Read(buffer, 0, buffer.Length);

        short headerLength = BitConverter.ToInt16(buffer, 0);
        short version = BitConverter.ToInt16(buffer, 2);
        long fileLength = BitConverter.ToInt64(buffer, 4);
        byte[] keyHash = new byte[32];
        Array.Copy(buffer, 12, keyHash, 0, 32);
        long time = BitConverter.ToInt64(buffer, 44);
        byte[] iv = new byte[16];
        Array.Copy(buffer, 52, iv, 0, 16);

        int fileNameLength = headerLength - 66; // 计算文件名长度
        byte[] fileNameBytes = new byte[fileNameLength];
        fs.Read(fileNameBytes, 0, fileNameLength);
        string fileName = Encoding.UTF8.GetString(fileNameBytes);

        return (version, fileLength, keyHash, time, iv, fileName);
    }

    public static (short version, long fileLength, byte[] keyHash, long time, string extension) ReadHeaderV1V2(FileStream fs)
    {
        byte[] buffer = new byte[2 + 2 + 8 + 32 + 8];
        fs.Read(buffer, 0, buffer.Length);

        short headerLength = BitConverter.ToInt16(buffer, 0);
        short version = BitConverter.ToInt16(buffer, 2);
        long fileLength = BitConverter.ToInt64(buffer, 4);
        byte[] keyHash = new byte[32];
        Array.Copy(buffer, 12, keyHash, 0, 32);
        long time = BitConverter.ToInt64(buffer, 44);

        byte[] extensionBytes = new byte[headerLength - 50];
        fs.Read(extensionBytes, 0, extensionBytes.Length);
        string extension = Encoding.UTF8.GetString(extensionBytes);

        return (version, fileLength, keyHash, time, extension);
    }
}

public static class Crc32
{
    private static readonly uint[] Table = new uint[256];
    private const uint Polynomial = 0xEDB88320;

    static Crc32()
    {
        for (uint i = 0; i < 256; i++)
        {
            uint crc = i;
            for (int j = 8; j > 0; j--)
            {
                if ((crc & 1) == 1)
                    crc = (crc >> 1) ^ Polynomial;
                else
                    crc >>= 1;
            }
            Table[i] = crc;
        }
    }

    public static uint Compute(byte[] data)
    {
        uint crc = 0xFFFFFFFF;
        foreach (byte b in data)
        {
            crc = (crc >> 8) ^ Table[(crc ^ b) & 0xFF];
        }
        return ~crc;
    }
}

public static class FileEncryption
{
    private const int BufferSize = 1024 * 1024; // 1MB缓冲区

    public static bool ENCFile(string fileInLocation, string fileReturnLocation, string encKey, long time, int type, CancellationToken token)
    {
        try
        {
            FileInfo fi = new FileInfo(fileInLocation);
            if ((type == 0 && fi.Length > 512 * 1024 * 1024) ||
                (type == 1 && fi.Length > 8192L * 1024 * 1024))
            {
                MessageBox.Show("文件过大，无法加密", "过大", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            using (FileStream inputStream = File.OpenRead(fileInLocation))
            {
                string outputPath = Path.Combine(fileReturnLocation,
                    Path.GetFileNameWithoutExtension(fileInLocation) + ".sf");

                using (FileStream outputStream = File.Create(outputPath))
                {
                    byte[] iv;
                    byte[] header = FileHeaderHandler.CreateHeader(
                        Path.GetFileName(fileInLocation), encKey, fi.Length, time, out iv); // 写入完整文件名
                    outputStream.Write(header, 0, header.Length);

                    using (Aes aes = Aes.Create())
                    {
                        using (SHA256 sha = SHA256.Create())
                        {
                            aes.Key = sha.ComputeHash(sha.ComputeHash(Encoding.UTF8.GetBytes(encKey)));
                        }
                        aes.IV = iv;
                        aes.Mode = CipherMode.CBC;
                        aes.Padding = PaddingMode.PKCS7;

                        using (CryptoStream cryptoStream = new CryptoStream(
                            outputStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            byte[] buffer = new byte[BufferSize];
                            int bytesRead;
                            while ((bytesRead = inputStream.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                if (token.IsCancellationRequested)
                                {
                                    outputStream.Close();
                                    File.Delete(outputPath);
                                    return false;
                                }

                                // 计算CRC32校验值并写入
                                uint crc = Crc32.Compute(buffer.Take(bytesRead).ToArray());
                                cryptoStream.Write(BitConverter.GetBytes(crc), 0, 4);
                                cryptoStream.Write(buffer, 0, bytesRead);
                            }
                        }
                    }
                }
            }
            return true;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"加密失败: {ex.Message}");
            return false;
        }
    }

    public static int DecFile(string fileInLocation, string fileReturnLocation, string decKey, CancellationToken token)
    {
        DateTime Localtime;
        try
        {
            NtpClient client = new NtpClient("ntp.ntsc.ac.cn");
            NtpClock clock = client.Query();
            Localtime = clock.Now.LocalDateTime;
        }
        catch { Localtime = DateTime.Now; }
        try
        {
            using (FileStream inputStream = File.OpenRead(fileInLocation))
            {
                short version = BitConverter.ToInt16(new byte[2], 0);
                inputStream.Seek(2, SeekOrigin.Begin);
                inputStream.Read(BitConverter.GetBytes(version), 0, 2);

                if (version == 3)
                {
                    var header = FileHeaderHandler.ReadHeader(inputStream);

                    if (DateTime.Compare(DateTime.FromBinary(header.time), Localtime) < 0)
                        return -2;

                    if (header.version != 3)
                        return -3;

                    byte[] decKeyHash;
                    using (SHA256 sha = SHA256.Create())
                    {
                        decKeyHash = sha.ComputeHash(sha.ComputeHash(Encoding.UTF8.GetBytes(decKey)));
                    }
                    if (!header.keyHash.SequenceEqual(decKeyHash))
                        return 0;

                    string outputPath = Path.Combine(fileReturnLocation, header.fileName);

                    using (FileStream outputStream = File.Create(outputPath))
                    using (Aes aes = Aes.Create())
                    {
                        aes.Key = decKeyHash;
                        aes.IV = header.iv;
                        aes.Mode = CipherMode.CBC;
                        aes.Padding = PaddingMode.PKCS7;

                        using (CryptoStream cryptoStream = new CryptoStream(
                            inputStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
                        {
                            byte[] buffer = new byte[BufferSize];
                            byte[] crcBuffer = new byte[4];
                            int bytesRead;
                            while ((bytesRead = cryptoStream.Read(crcBuffer, 0, 4)) > 0)
                            {
                                if (token.IsCancellationRequested)
                                {
                                    outputStream.Close();
                                    File.Delete(outputPath);
                                    return 1;
                                }

                                uint expectedCrc = BitConverter.ToUInt32(crcBuffer, 0);
                                bytesRead = cryptoStream.Read(buffer, 0, buffer.Length);
                                if (bytesRead == 0) break;

                                // 计算实际CRC32校验值
                                uint actualCrc = Crc32.Compute(buffer.Take(bytesRead).ToArray());
                                if (expectedCrc != actualCrc)
                                {
                                    outputStream.Close();
                                    File.Delete(outputPath);
                                    return 3; // 校验失败
                                }

                                outputStream.Write(buffer, 0, bytesRead);
                            }
                        }
                    }
                }
                else if (version == 1 || version == 2)
                {
                    var header = FileHeaderHandler.ReadHeaderV1V2(inputStream);

                    if (DateTime.Compare(DateTime.FromBinary(header.time), Localtime) < 0)
                        return -2;

                    if (header.version != 1 && header.version != 2)
                        return -3;

                    byte[] decKeyHash;
                    using (SHA256 sha = SHA256.Create())
                    {
                        decKeyHash = sha.ComputeHash(sha.ComputeHash(Encoding.UTF8.GetBytes(decKey)));
                    }
                    if (!header.keyHash.SequenceEqual(decKeyHash))
                        return 0;

                    string outputPath = Path.Combine(fileReturnLocation, Path.GetFileNameWithoutExtension(fileInLocation) + header.extension);

                    using (FileStream outputStream = File.Create(outputPath))
                    using (Aes aes = Aes.Create())
                    {
                        aes.Key = decKeyHash;
                        aes.IV = Encoding.UTF8.GetBytes("1234567890123456");
                        aes.Mode = CipherMode.CBC;
                        aes.Padding = PaddingMode.Zeros;

                        using (CryptoStream cryptoStream = new CryptoStream(
                            inputStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
                        {
                            byte[] buffer = new byte[BufferSize];
                            int bytesRead;
                            while ((bytesRead = cryptoStream.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                if (token.IsCancellationRequested)
                                {
                                    outputStream.Close();
                                    File.Delete(outputPath);
                                    return 1;
                                }

                                outputStream.Write(buffer, 0, bytesRead);
                            }
                        }
                    }
                }
                else
                {
                    return -3; // 版本不支持
                }
                return 2;
            }
        }
        catch (CryptographicException)
        {
            return 0; // 密钥错误
        }
        catch (Exception)
        {
            return -1;
        }
    }
}
