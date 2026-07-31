using GuerrillaNtp;
using Microsoft.Win32;
using SafeFile.Properties;
using Sunny.UI;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafeFile
{
    public partial class MainForm : Form
    {
        CancellationTokenSource ctsEnc = new CancellationTokenSource();
        CancellationTokenSource ctsDec = new CancellationTokenSource();
        OpenFileDialog chooseFileEncInput = new OpenFileDialog()
        {
            Filter = "任何文件(*.*)|*.*",
            Title = "选择文件"
        };//定义用于选择待加密文件的文件选择框
        FolderBrowserDialog chooseFileEncReturn = new FolderBrowserDialog()
        {
            Description = "文件输出目录",
        };//定义用于选择密文文件输出目录的文件夹选择框
        OpenFileDialog chooseFileDecInput = new OpenFileDialog()
        {
            Filter = "SafeFile文件(*.sf)|*.sf",
            Title = "选择文件"
        };//定义只允许选择.sf格式文件的文件选择框
        FolderBrowserDialog chooseFileDecReturn = new FolderBrowserDialog()
        {
            Description = "文件输出目录"
        };//定义用于选择解密后的文件输出目录的文件夹选择框
        FolderBrowserDialog chooseZipReturn = new FolderBrowserDialog()
        {
            Description = "选择待压缩的文件夹"
        };//压缩输出目录
        FolderBrowserDialog chooseZipFile = new FolderBrowserDialog();//压缩输入文件
        OpenFileDialog chooseZipDecompression = new OpenFileDialog()
        {
            Filter = "Zip压缩包(*.zip)|*.zip",
            Title = "选择文件"
        };//定义只允许选择.zip格式文件的文件选择框
        FolderBrowserDialog chooseZipDecompressionReturnFile = new FolderBrowserDialog();//压缩输入文件



        int ActEncType = 0;

        public MainForm()
        {

            InitializeComponent();
            uiDatetimePickerFileCanUseTime.Value = DateTime.Now;
            chooseFileEncInput.FileName = string.Empty;
            chooseFileDecInput.FileName = string.Empty;
            chooseFileDecReturn.SelectedPath = string.Empty;
            chooseFileEncReturn.SelectedPath = string.Empty;
            chooseZipFile.SelectedPath = string.Empty;
            chooseZipReturn.SelectedPath = string.Empty;

        }

        private void uiCheckBoxDisplayPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxInptPasswordEnc.UseSystemPasswordChar = !uiCheckBoxDisplayPasswordEnc.Checked;//设置是否显示密码
        }

        private void buttonStartDec_Click(object sender, EventArgs e)
        {
            uiWaitingBarDEC.Visible = true;
            buttonDecCancel.Enabled = true;
            int IsDelFileCount = 0;
            int typeNumber;
            Task.Factory.StartNew(() =>
            {
                ctsDec = new CancellationTokenSource();
                typeNumber = FileEncryption.DecFile(chooseFileDecInput.FileName, chooseFileDecReturn.SelectedPath, textBoxpasswordDec.Text, ctsDec.Token);
                if (typeNumber == 2)
                {
                    MessageBox.Show("解密完成", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Invoke(new Action(() =>
                    {
                        buttonDecCancel.Enabled = false;
                        uiWaitingBarDEC.Visible = false;
                    }));
                }
                else
                {
                    if (typeNumber == -1)
                    {
                        MessageBox.Show("缺少参数", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Invoke(new Action(() =>
                        {
                            buttonDecCancel.Enabled = false;
                            uiWaitingBarDEC.Visible = false;
                        }));
                    }
                    else
                    {
                        if (typeNumber == -2)
                        {
                            MessageBox.Show("文件已过期", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Invoke(new Action(() =>
                            {
                                buttonDecCancel.Enabled = false;
                                uiWaitingBarDEC.Visible = false;
                            }));
                        }

                        else
                        {
                            if (typeNumber == -3)
                            {
                                MessageBox.Show("程序不兼容此版本", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                Invoke(new Action(() =>
                                {
                                    buttonDecCancel.Enabled = false;
                                    uiWaitingBarDEC.Visible = false;
                                }));
                            }
                            else
                            {
                                if (typeNumber == 0)
                                {
                                    MessageBox.Show("密码错误", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Invoke(new Action(() =>
                                    {
                                        buttonDecCancel.Enabled = false;
                                        uiWaitingBarDEC.Visible = false;
                                        IsDelFileCount++;
                                    }));
                                }
                                else
                                {
                                    if (typeNumber == 1)
                                    {
                                        MessageBox.Show("用户取消操作", "解密已终止", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Invoke(new Action(() =>
                                        {
                                            buttonDecCancel.Enabled = false;
                                            uiWaitingBarDEC.Visible = false;
                                        }));
                                    }

                                }
                            }
                        }
                    };
                }
            });

        }

        private void uiCheckBoxDisplay_CheckedChanged(object sender, EventArgs e)
        {
            textBoxpasswordDec.UseSystemPasswordChar = !uiCheckBoxDisplay.Checked;//是否解密密码输入区显示密码
        }

        private void buttonFileLocationDEC_Click(object sender, EventArgs e)
        {
            chooseFileDecInput.ShowDialog();//显示.sf格式文件选择框
            textBoxFileLocationDEC.Text = chooseFileDecInput.FileName;//将文件地址显示在地址显示框中
        }


        private void buttonStartENC_Click(object sender, EventArgs e)
        {
            buttonEncCanel.Enabled = true;
            uiWaitingBarENC.Visible = true;//显示摆渡式进度条
            Int64 time = uiDatetimePickerFileCanUseTime.Value.ToBinary();//将时期格式化为正确格式
            ctsEnc = new CancellationTokenSource();
            Task.Factory.StartNew(() =>
            {
                if (FileEncryption.ENCFile(chooseFileEncInput.FileName, chooseFileEncReturn.SelectedPath, textBoxInptPasswordEnc.Text, time, ActEncType, ctsEnc.Token))
                {
                    Invoke(new Action(() =>
                        {
                            buttonEncCanel.Enabled = false;
                        }));
                    MessageBox.Show("加密完成", "加密完成", MessageBoxButtons.OK, MessageBoxIcon.Information);//显示成功加密信息}
                    Invoke(new Action(() =>
                        {
                            uiWaitingBarENC.Visible = false;//加密完成后停止显示摆渡式进度条
                        }));
                }

                else { MessageBox.Show("加密已取消", "加密已终止", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            });
        }

        private void buttonChooseReturnFileLocationEnc_Click(object sender, EventArgs e)
        {
            chooseFileEncReturn.ShowDialog();//显示文件夹选择框
            textBoxFileReturnLocationEnc.Text = chooseFileEncReturn.SelectedPath;//将文件夹地址显示在文件夹地址显示框
        }

        private void buttonChooseReturnFileLocationDec_Click(object sender, EventArgs e)
        {
            chooseFileDecReturn.ShowDialog();//显示文件夹选择框
            textBoxReturnFileLocationDEC.Text = chooseFileDecReturn.SelectedPath;//将文件夹地址显示在文件夹地址显示框

        }

        private void buttonChooseFileEnc_Click(object sender, EventArgs e)
        {
            chooseFileEncInput.ShowDialog();//显示选择文件
            textBoxFileLocationEnc.Text = chooseFileEncInput.FileName;//在文件地址显示框中显示文件地址
        }

        private void buttonZipFile_Click(object sender, EventArgs e)
        {
            chooseZipFile.ShowDialog();
            textBoxZipfile.Text = chooseZipFile.SelectedPath;
        }

        private void buttonZipReturnLoctain_Click(object sender, EventArgs e)
        {
            chooseZipReturn.ShowDialog();
            textBoxZipReturnLoctain.Text = chooseZipReturn.SelectedPath;
        }

        private void buttonStartZip_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                string fileName = chooseZipReturn.SelectedPath + "SafeFile_" + DateTime.Now.Year.ToString() + "." + DateTime.Now.Month + "." + DateTime.Now.Day.ToString() + "_" + "Compress" + ".zip";
                ZipFile.CreateFromDirectory(chooseZipFile.SelectedPath, fileName);
                MessageBox.Show("完成", "压缩完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
            });
        }

        private void buttonEncCanel_Click(object sender, EventArgs e)
        {
            ctsEnc.Cancel();
            buttonEncCanel.Enabled = false;
            uiWaitingBarENC.Visible = false;

        }

        private void buttonDecCancel_Click(object sender, EventArgs e)
        {
            ctsDec.Cancel();
            buttonDecCancel.Enabled = false;
            uiWaitingBarDEC.Visible = false;
        }

        private void buttonChooseDecompressionFile_Click(object sender, EventArgs e)
        {
            chooseZipDecompression.ShowDialog();
            textBoxdecompression.Text = chooseZipDecompression.FileName;
        }

        private void buttonChooseDecompressionReturn_Click(object sender, EventArgs e)
        {
            chooseZipDecompressionReturnFile.ShowDialog();
            textBoxDecompressionReturnPath.Text = chooseZipDecompressionReturnFile.SelectedPath;
        }

        private void buttonStartDecompression_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                ZipFile.ExtractToDirectory(chooseZipDecompression.FileName, chooseZipDecompressionReturnFile.SelectedPath);
                MessageBox.Show("解压完成", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
            });
        }



        private void GetParentsName(TreeNode Node, ref List<String> NameList)
        {
            NameList.Add(Node.Text);
            if (Node.Parent != null)
            {
                //递归
                GetParentsName(Node.Parent, ref NameList);
            }
        }

    }
}