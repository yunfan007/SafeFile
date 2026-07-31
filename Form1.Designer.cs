namespace SafeFile
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.uiDatetimePickerChooseTime = new Sunny.UI.UIDatetimePicker();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.uiTextBoxAboutText = new Sunny.UI.UITextBox();
            this.pictureBoxAboutPicture = new System.Windows.Forms.PictureBox();
            this.tabPageZipFile = new System.Windows.Forms.TabPage();
            this.buttonStartDecompression = new System.Windows.Forms.Button();
            this.buttonChooseDecompressionFile = new System.Windows.Forms.Button();
            this.textBoxdecompression = new System.Windows.Forms.TextBox();
            this.textBoxDecompressionReturnPath = new System.Windows.Forms.TextBox();
            this.textBoxZipfile = new System.Windows.Forms.TextBox();
            this.textBoxZipReturnLoctain = new System.Windows.Forms.TextBox();
            this.buttonChooseDecompressionReturn = new System.Windows.Forms.Button();
            this.buttonStartZip = new System.Windows.Forms.Button();
            this.buttonChooseZipFile = new System.Windows.Forms.Button();
            this.buttonZipReturnLoctain = new System.Windows.Forms.Button();
            this.tabPageDEC = new System.Windows.Forms.TabPage();
            this.groupBoxDec = new System.Windows.Forms.GroupBox();
            this.buttonDecCancel = new System.Windows.Forms.Button();
            this.buttonChooseReturnFileLocationDec = new System.Windows.Forms.Button();
            this.textBoxReturnFileLocationDEC = new System.Windows.Forms.TextBox();
            this.uiWaitingBarDEC = new Sunny.UI.UIWaitingBar();
            this.buttonStartDec = new System.Windows.Forms.Button();
            this.labelPasswordTipDec = new System.Windows.Forms.Label();
            this.uiCheckBoxDisplay = new Sunny.UI.UICheckBox();
            this.textBoxpasswordDec = new System.Windows.Forms.TextBox();
            this.buttonFileLocationDEC = new System.Windows.Forms.Button();
            this.textBoxFileLocationDEC = new System.Windows.Forms.TextBox();
            this.tabPageENC = new System.Windows.Forms.TabPage();
            this.groupBoxEnc = new System.Windows.Forms.GroupBox();
            this.buttonEncCanel = new System.Windows.Forms.Button();
            this.buttonChooseReturnFileLocationEnc = new System.Windows.Forms.Button();
            this.textBoxFileReturnLocationEnc = new System.Windows.Forms.TextBox();
            this.uiDatetimePickerFileCanUseTime = new Sunny.UI.UIDatetimePicker();
            this.uiWaitingBarENC = new Sunny.UI.UIWaitingBar();
            this.labelChooseTimeTip = new System.Windows.Forms.Label();
            this.buttonChooseFileEnc = new System.Windows.Forms.Button();
            this.textBoxFileLocationEnc = new System.Windows.Forms.TextBox();
            this.labelChoosePasswordTipEnc = new System.Windows.Forms.Label();
            this.buttonStartENC = new System.Windows.Forms.Button();
            this.uiCheckBoxDisplayPasswordEnc = new Sunny.UI.UICheckBox();
            this.textBoxInptPasswordEnc = new System.Windows.Forms.TextBox();
            this.uiTabControlMenuMain = new Sunny.UI.UITabControlMenu();
            this.openFileDialogAct = new System.Windows.Forms.OpenFileDialog();
            this.tabPageAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAboutPicture)).BeginInit();
            this.tabPageZipFile.SuspendLayout();
            this.tabPageDEC.SuspendLayout();
            this.groupBoxDec.SuspendLayout();
            this.tabPageENC.SuspendLayout();
            this.groupBoxEnc.SuspendLayout();
            this.uiTabControlMenuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiDatetimePickerChooseTime
            // 
            this.uiDatetimePickerChooseTime.FillColor = System.Drawing.Color.White;
            this.uiDatetimePickerChooseTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiDatetimePickerChooseTime.Location = new System.Drawing.Point(112, 290);
            this.uiDatetimePickerChooseTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiDatetimePickerChooseTime.MaxLength = 19;
            this.uiDatetimePickerChooseTime.MinimumSize = new System.Drawing.Size(47, 0);
            this.uiDatetimePickerChooseTime.Name = "uiDatetimePickerChooseTime";
            this.uiDatetimePickerChooseTime.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiDatetimePickerChooseTime.Size = new System.Drawing.Size(680, 29);
            this.uiDatetimePickerChooseTime.SymbolDropDown = 61555;
            this.uiDatetimePickerChooseTime.SymbolNormal = 61555;
            this.uiDatetimePickerChooseTime.SymbolSize = 24;
            this.uiDatetimePickerChooseTime.TabIndex = 5;
            this.uiDatetimePickerChooseTime.Text = "2024-07-18 19:25:40";
            this.uiDatetimePickerChooseTime.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiDatetimePickerChooseTime.Value = new System.DateTime(2024, 7, 18, 19, 25, 40, 103);
            this.uiDatetimePickerChooseTime.Watermark = "";
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Controls.Add(this.uiTextBoxAboutText);
            this.tabPageAbout.Controls.Add(this.pictureBoxAboutPicture);
            this.tabPageAbout.Location = new System.Drawing.Point(201, 0);
            this.tabPageAbout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Size = new System.Drawing.Size(877, 658);
            this.tabPageAbout.TabIndex = 3;
            this.tabPageAbout.Text = "关于软件";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // uiTextBoxAboutText
            // 
            this.uiTextBoxAboutText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBoxAboutText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiTextBoxAboutText.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBoxAboutText.Location = new System.Drawing.Point(0, 193);
            this.uiTextBoxAboutText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiTextBoxAboutText.MinimumSize = new System.Drawing.Size(1, 13);
            this.uiTextBoxAboutText.Multiline = true;
            this.uiTextBoxAboutText.Name = "uiTextBoxAboutText";
            this.uiTextBoxAboutText.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiTextBoxAboutText.ReadOnly = true;
            this.uiTextBoxAboutText.ShowText = false;
            this.uiTextBoxAboutText.Size = new System.Drawing.Size(877, 465);
            this.uiTextBoxAboutText.TabIndex = 0;
            this.uiTextBoxAboutText.Text = resources.GetString("uiTextBoxAboutText.Text");
            this.uiTextBoxAboutText.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiTextBoxAboutText.Watermark = "";
            // 
            // pictureBoxAboutPicture
            // 
            this.pictureBoxAboutPicture.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAboutPicture.Image")));
            this.pictureBoxAboutPicture.Location = new System.Drawing.Point(313, 11);
            this.pictureBoxAboutPicture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxAboutPicture.Name = "pictureBoxAboutPicture";
            this.pictureBoxAboutPicture.Size = new System.Drawing.Size(227, 195);
            this.pictureBoxAboutPicture.TabIndex = 0;
            this.pictureBoxAboutPicture.TabStop = false;
            // 
            // tabPageZipFile
            // 
            this.tabPageZipFile.Controls.Add(this.buttonStartDecompression);
            this.tabPageZipFile.Controls.Add(this.buttonChooseDecompressionFile);
            this.tabPageZipFile.Controls.Add(this.textBoxdecompression);
            this.tabPageZipFile.Controls.Add(this.textBoxDecompressionReturnPath);
            this.tabPageZipFile.Controls.Add(this.textBoxZipfile);
            this.tabPageZipFile.Controls.Add(this.textBoxZipReturnLoctain);
            this.tabPageZipFile.Controls.Add(this.buttonChooseDecompressionReturn);
            this.tabPageZipFile.Controls.Add(this.buttonStartZip);
            this.tabPageZipFile.Controls.Add(this.buttonChooseZipFile);
            this.tabPageZipFile.Controls.Add(this.buttonZipReturnLoctain);
            this.tabPageZipFile.Location = new System.Drawing.Point(201, 0);
            this.tabPageZipFile.Name = "tabPageZipFile";
            this.tabPageZipFile.Size = new System.Drawing.Size(877, 658);
            this.tabPageZipFile.TabIndex = 4;
            this.tabPageZipFile.Text = "打包文件";
            this.tabPageZipFile.UseVisualStyleBackColor = true;
            // 
            // buttonStartDecompression
            // 
            this.buttonStartDecompression.ForeColor = System.Drawing.Color.Black;
            this.buttonStartDecompression.Location = new System.Drawing.Point(2, 553);
            this.buttonStartDecompression.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonStartDecompression.Name = "buttonStartDecompression";
            this.buttonStartDecompression.Size = new System.Drawing.Size(870, 46);
            this.buttonStartDecompression.TabIndex = 15;
            this.buttonStartDecompression.Text = "解压";
            this.buttonStartDecompression.UseVisualStyleBackColor = true;
            this.buttonStartDecompression.Click += new System.EventHandler(this.buttonStartDecompression_Click);
            // 
            // buttonChooseDecompressionFile
            // 
            this.buttonChooseDecompressionFile.ForeColor = System.Drawing.Color.Black;
            this.buttonChooseDecompressionFile.Location = new System.Drawing.Point(695, 397);
            this.buttonChooseDecompressionFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonChooseDecompressionFile.Name = "buttonChooseDecompressionFile";
            this.buttonChooseDecompressionFile.Size = new System.Drawing.Size(177, 26);
            this.buttonChooseDecompressionFile.TabIndex = 14;
            this.buttonChooseDecompressionFile.Text = "选择文件";
            this.buttonChooseDecompressionFile.UseVisualStyleBackColor = true;
            this.buttonChooseDecompressionFile.Click += new System.EventHandler(this.buttonChooseDecompressionFile_Click);
            // 
            // textBoxdecompression
            // 
            this.textBoxdecompression.Location = new System.Drawing.Point(2, 399);
            this.textBoxdecompression.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxdecompression.Name = "textBoxdecompression";
            this.textBoxdecompression.ReadOnly = true;
            this.textBoxdecompression.Size = new System.Drawing.Size(669, 23);
            this.textBoxdecompression.TabIndex = 13;
            // 
            // textBoxDecompressionReturnPath
            // 
            this.textBoxDecompressionReturnPath.Location = new System.Drawing.Point(5, 481);
            this.textBoxDecompressionReturnPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDecompressionReturnPath.Name = "textBoxDecompressionReturnPath";
            this.textBoxDecompressionReturnPath.ReadOnly = true;
            this.textBoxDecompressionReturnPath.Size = new System.Drawing.Size(666, 23);
            this.textBoxDecompressionReturnPath.TabIndex = 11;
            // 
            // textBoxZipfile
            // 
            this.textBoxZipfile.Location = new System.Drawing.Point(5, 72);
            this.textBoxZipfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxZipfile.Name = "textBoxZipfile";
            this.textBoxZipfile.ReadOnly = true;
            this.textBoxZipfile.Size = new System.Drawing.Size(658, 23);
            this.textBoxZipfile.TabIndex = 6;
            // 
            // textBoxZipReturnLoctain
            // 
            this.textBoxZipReturnLoctain.Location = new System.Drawing.Point(5, 154);
            this.textBoxZipReturnLoctain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxZipReturnLoctain.Name = "textBoxZipReturnLoctain";
            this.textBoxZipReturnLoctain.ReadOnly = true;
            this.textBoxZipReturnLoctain.Size = new System.Drawing.Size(666, 23);
            this.textBoxZipReturnLoctain.TabIndex = 4;
            // 
            // buttonChooseDecompressionReturn
            // 
            this.buttonChooseDecompressionReturn.ForeColor = System.Drawing.Color.Black;
            this.buttonChooseDecompressionReturn.Location = new System.Drawing.Point(695, 479);
            this.buttonChooseDecompressionReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonChooseDecompressionReturn.Name = "buttonChooseDecompressionReturn";
            this.buttonChooseDecompressionReturn.Size = new System.Drawing.Size(177, 26);
            this.buttonChooseDecompressionReturn.TabIndex = 12;
            this.buttonChooseDecompressionReturn.Text = "选择输出文件夹";
            this.buttonChooseDecompressionReturn.UseVisualStyleBackColor = true;
            this.buttonChooseDecompressionReturn.Click += new System.EventHandler(this.buttonChooseDecompressionReturn_Click);
            // 
            // buttonStartZip
            // 
            this.buttonStartZip.ForeColor = System.Drawing.Color.Black;
            this.buttonStartZip.Location = new System.Drawing.Point(5, 222);
            this.buttonStartZip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonStartZip.Name = "buttonStartZip";
            this.buttonStartZip.Size = new System.Drawing.Size(870, 46);
            this.buttonStartZip.TabIndex = 10;
            this.buttonStartZip.Text = "压缩";
            this.buttonStartZip.UseVisualStyleBackColor = true;
            this.buttonStartZip.Click += new System.EventHandler(this.buttonStartZip_Click);
            // 
            // buttonChooseZipFile
            // 
            this.buttonChooseZipFile.ForeColor = System.Drawing.Color.Black;
            this.buttonChooseZipFile.Location = new System.Drawing.Point(695, 72);
            this.buttonChooseZipFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonChooseZipFile.Name = "buttonChooseZipFile";
            this.buttonChooseZipFile.Size = new System.Drawing.Size(177, 26);
            this.buttonChooseZipFile.TabIndex = 7;
            this.buttonChooseZipFile.Text = "选择文件夹";
            this.buttonChooseZipFile.UseVisualStyleBackColor = true;
            this.buttonChooseZipFile.Click += new System.EventHandler(this.buttonZipFile_Click);
            // 
            // buttonZipReturnLoctain
            // 
            this.buttonZipReturnLoctain.ForeColor = System.Drawing.Color.Black;
            this.buttonZipReturnLoctain.Location = new System.Drawing.Point(695, 152);
            this.buttonZipReturnLoctain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonZipReturnLoctain.Name = "buttonZipReturnLoctain";
            this.buttonZipReturnLoctain.Size = new System.Drawing.Size(177, 26);
            this.buttonZipReturnLoctain.TabIndex = 5;
            this.buttonZipReturnLoctain.Text = "选择输出文件夹";
            this.buttonZipReturnLoctain.UseVisualStyleBackColor = true;
            this.buttonZipReturnLoctain.Click += new System.EventHandler(this.buttonZipReturnLoctain_Click);
            // 
            // tabPageDEC
            // 
            this.tabPageDEC.Controls.Add(this.groupBoxDec);
            this.tabPageDEC.Location = new System.Drawing.Point(201, 0);
            this.tabPageDEC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageDEC.Name = "tabPageDEC";
            this.tabPageDEC.Size = new System.Drawing.Size(875, 651);
            this.tabPageDEC.TabIndex = 1;
            this.tabPageDEC.Text = "解密文件";
            this.tabPageDEC.UseVisualStyleBackColor = true;
            // 
            // groupBoxDec
            // 
            this.groupBoxDec.Controls.Add(this.buttonDecCancel);
            this.groupBoxDec.Controls.Add(this.buttonChooseReturnFileLocationDec);
            this.groupBoxDec.Controls.Add(this.textBoxReturnFileLocationDEC);
            this.groupBoxDec.Controls.Add(this.uiWaitingBarDEC);
            this.groupBoxDec.Controls.Add(this.buttonStartDec);
            this.groupBoxDec.Controls.Add(this.labelPasswordTipDec);
            this.groupBoxDec.Controls.Add(this.uiCheckBoxDisplay);
            this.groupBoxDec.Controls.Add(this.textBoxpasswordDec);
            this.groupBoxDec.Controls.Add(this.buttonFileLocationDEC);
            this.groupBoxDec.Controls.Add(this.textBoxFileLocationDEC);
            this.groupBoxDec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDec.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDec.Name = "groupBoxDec";
            this.groupBoxDec.Size = new System.Drawing.Size(875, 651);
            this.groupBoxDec.TabIndex = 0;
            this.groupBoxDec.TabStop = false;
            // 
            // buttonDecCancel
            // 
            this.buttonDecCancel.Enabled = false;
            this.buttonDecCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonDecCancel.Location = new System.Drawing.Point(441, 598);
            this.buttonDecCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDecCancel.Name = "buttonDecCancel";
            this.buttonDecCancel.Size = new System.Drawing.Size(434, 46);
            this.buttonDecCancel.TabIndex = 9;
            this.buttonDecCancel.Text = "取消";
            this.buttonDecCancel.UseVisualStyleBackColor = true;
            this.buttonDecCancel.Click += new System.EventHandler(this.buttonDecCancel_Click);
            // 
            // buttonChooseReturnFileLocationDec
            // 
            this.buttonChooseReturnFileLocationDec.ForeColor = System.Drawing.Color.Black;
            this.buttonChooseReturnFileLocationDec.Location = new System.Drawing.Point(705, 146);
            this.buttonChooseReturnFileLocationDec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonChooseReturnFileLocationDec.Name = "buttonChooseReturnFileLocationDec";
            this.buttonChooseReturnFileLocationDec.Size = new System.Drawing.Size(144, 26);
            this.buttonChooseReturnFileLocationDec.TabIndex = 8;
            this.buttonChooseReturnFileLocationDec.Text = "选择输出文件夹";
            this.buttonChooseReturnFileLocationDec.UseVisualStyleBackColor = true;
            this.buttonChooseReturnFileLocationDec.Click += new System.EventHandler(this.buttonChooseReturnFileLocationDec_Click);
            // 
            // textBoxReturnFileLocationDEC
            // 
            this.textBoxReturnFileLocationDEC.Location = new System.Drawing.Point(40, 146);
            this.textBoxReturnFileLocationDEC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxReturnFileLocationDEC.Name = "textBoxReturnFileLocationDEC";
            this.textBoxReturnFileLocationDEC.ReadOnly = true;
            this.textBoxReturnFileLocationDEC.Size = new System.Drawing.Size(626, 23);
            this.textBoxReturnFileLocationDEC.TabIndex = 7;
            // 
            // uiWaitingBarDEC
            // 
            this.uiWaitingBarDEC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiWaitingBarDEC.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiWaitingBarDEC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiWaitingBarDEC.Location = new System.Drawing.Point(0, 649);
            this.uiWaitingBarDEC.MinimumSize = new System.Drawing.Size(70, 23);
            this.uiWaitingBarDEC.Name = "uiWaitingBarDEC";
            this.uiWaitingBarDEC.Size = new System.Drawing.Size(874, 29);
            this.uiWaitingBarDEC.TabIndex = 6;
            this.uiWaitingBarDEC.Text = "uiWaitingBarEnc";
            this.uiWaitingBarDEC.Visible = false;
            // 
            // buttonStartDec
            // 
            this.buttonStartDec.ForeColor = System.Drawing.Color.Black;
            this.buttonStartDec.Location = new System.Drawing.Point(2, 598);
            this.buttonStartDec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonStartDec.Name = "buttonStartDec";
            this.buttonStartDec.Size = new System.Drawing.Size(434, 46);
            this.buttonStartDec.TabIndex = 5;
            this.buttonStartDec.Text = "解密";
            this.buttonStartDec.UseVisualStyleBackColor = true;
            this.buttonStartDec.Click += new System.EventHandler(this.buttonStartDec_Click);
            // 
            // labelPasswordTipDec
            // 
            this.labelPasswordTipDec.AutoSize = true;
            this.labelPasswordTipDec.ForeColor = System.Drawing.Color.Black;
            this.labelPasswordTipDec.Location = new System.Drawing.Point(37, 213);
            this.labelPasswordTipDec.Name = "labelPasswordTipDec";
            this.labelPasswordTipDec.Size = new System.Drawing.Size(32, 17);
            this.labelPasswordTipDec.TabIndex = 2;
            this.labelPasswordTipDec.Text = "密码";
            // 
            // uiCheckBoxDisplay
            // 
            this.uiCheckBoxDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBoxDisplay.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiCheckBoxDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiCheckBoxDisplay.Location = new System.Drawing.Point(714, 213);
            this.uiCheckBoxDisplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uiCheckBoxDisplay.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBoxDisplay.Name = "uiCheckBoxDisplay";
            this.uiCheckBoxDisplay.Size = new System.Drawing.Size(100, 23);
            this.uiCheckBoxDisplay.TabIndex = 4;
            this.uiCheckBoxDisplay.Text = "显示密码";
            this.uiCheckBoxDisplay.CheckedChanged += new System.EventHandler(this.uiCheckBoxDisplay_CheckedChanged);
            // 
            // textBoxpasswordDec
            // 
            this.textBoxpasswordDec.Location = new System.Drawing.Point(97, 210);
            this.textBoxpasswordDec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxpasswordDec.MaxLength = 999;
            this.textBoxpasswordDec.Name = "textBoxpasswordDec";
            this.textBoxpasswordDec.Size = new System.Drawing.Size(569, 23);
            this.textBoxpasswordDec.TabIndex = 3;
            this.textBoxpasswordDec.UseSystemPasswordChar = true;
            // 
            // buttonFileLocationDEC
            // 
            this.buttonFileLocationDEC.ForeColor = System.Drawing.Color.Black;
            this.buttonFileLocationDEC.Location = new System.Drawing.Point(705, 68);
            this.buttonFileLocationDEC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonFileLocationDEC.Name = "buttonFileLocationDEC";
            this.buttonFileLocationDEC.Size = new System.Drawing.Size(144, 26);
            this.buttonFileLocationDEC.TabIndex = 1;
            this.buttonFileLocationDEC.Text = "选择文件";
            this.buttonFileLocationDEC.UseVisualStyleBackColor = true;
            this.buttonFileLocationDEC.Click += new System.EventHandler(this.buttonFileLocationDEC_Click);
            // 
            // textBoxFileLocationDEC
            // 
            this.textBoxFileLocationDEC.Location = new System.Drawing.Point(40, 68);
            this.textBoxFileLocationDEC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFileLocationDEC.Name = "textBoxFileLocationDEC";
            this.textBoxFileLocationDEC.ReadOnly = true;
            this.textBoxFileLocationDEC.Size = new System.Drawing.Size(626, 23);
            this.textBoxFileLocationDEC.TabIndex = 0;
            // 
            // tabPageENC
            // 
            this.tabPageENC.Controls.Add(this.groupBoxEnc);
            this.tabPageENC.Location = new System.Drawing.Point(201, 0);
            this.tabPageENC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageENC.Name = "tabPageENC";
            this.tabPageENC.Size = new System.Drawing.Size(877, 658);
            this.tabPageENC.TabIndex = 0;
            this.tabPageENC.Text = "加密文件";
            this.tabPageENC.UseVisualStyleBackColor = true;
            // 
            // groupBoxEnc
            // 
            this.groupBoxEnc.Controls.Add(this.buttonEncCanel);
            this.groupBoxEnc.Controls.Add(this.buttonChooseReturnFileLocationEnc);
            this.groupBoxEnc.Controls.Add(this.textBoxFileReturnLocationEnc);
            this.groupBoxEnc.Controls.Add(this.uiDatetimePickerFileCanUseTime);
            this.groupBoxEnc.Controls.Add(this.uiWaitingBarENC);
            this.groupBoxEnc.Controls.Add(this.labelChooseTimeTip);
            this.groupBoxEnc.Controls.Add(this.buttonChooseFileEnc);
            this.groupBoxEnc.Controls.Add(this.textBoxFileLocationEnc);
            this.groupBoxEnc.Controls.Add(this.labelChoosePasswordTipEnc);
            this.groupBoxEnc.Controls.Add(this.buttonStartENC);
            this.groupBoxEnc.Controls.Add(this.uiCheckBoxDisplayPasswordEnc);
            this.groupBoxEnc.Controls.Add(this.textBoxInptPasswordEnc);
            this.groupBoxEnc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxEnc.ForeColor = System.Drawing.Color.Black;
            this.groupBoxEnc.Location = new System.Drawing.Point(0, 0);
            this.groupBoxEnc.Name = "groupBoxEnc";
            this.groupBoxEnc.Size = new System.Drawing.Size(877, 658);
            this.groupBoxEnc.TabIndex = 0;
            this.groupBoxEnc.TabStop = false;
            // 
            // buttonEncCanel
            // 
            this.buttonEncCanel.Enabled = false;
            this.buttonEncCanel.ForeColor = System.Drawing.Color.Black;
            this.buttonEncCanel.Location = new System.Drawing.Point(445, 596);
            this.buttonEncCanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEncCanel.Name = "buttonEncCanel";
            this.buttonEncCanel.Size = new System.Drawing.Size(426, 46);
            this.buttonEncCanel.TabIndex = 11;
            this.buttonEncCanel.Text = "取消";
            this.buttonEncCanel.UseVisualStyleBackColor = true;
            this.buttonEncCanel.Click += new System.EventHandler(this.buttonEncCanel_Click);
            // 
            // buttonChooseReturnFileLocationEnc
            // 
            this.buttonChooseReturnFileLocationEnc.ForeColor = System.Drawing.Color.Black;
            this.buttonChooseReturnFileLocationEnc.Location = new System.Drawing.Point(660, 131);
            this.buttonChooseReturnFileLocationEnc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonChooseReturnFileLocationEnc.Name = "buttonChooseReturnFileLocationEnc";
            this.buttonChooseReturnFileLocationEnc.Size = new System.Drawing.Size(132, 26);
            this.buttonChooseReturnFileLocationEnc.TabIndex = 3;
            this.buttonChooseReturnFileLocationEnc.Text = "选择输出文件夹";
            this.buttonChooseReturnFileLocationEnc.UseVisualStyleBackColor = true;
            this.buttonChooseReturnFileLocationEnc.Click += new System.EventHandler(this.buttonChooseReturnFileLocationEnc_Click);
            // 
            // textBoxFileReturnLocationEnc
            // 
            this.textBoxFileReturnLocationEnc.Location = new System.Drawing.Point(18, 133);
            this.textBoxFileReturnLocationEnc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFileReturnLocationEnc.Name = "textBoxFileReturnLocationEnc";
            this.textBoxFileReturnLocationEnc.ReadOnly = true;
            this.textBoxFileReturnLocationEnc.Size = new System.Drawing.Size(626, 23);
            this.textBoxFileReturnLocationEnc.TabIndex = 2;
            // 
            // uiDatetimePickerFileCanUseTime
            // 
            this.uiDatetimePickerFileCanUseTime.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.uiDatetimePickerFileCanUseTime.FillColor = System.Drawing.Color.White;
            this.uiDatetimePickerFileCanUseTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiDatetimePickerFileCanUseTime.Location = new System.Drawing.Point(93, 290);
            this.uiDatetimePickerFileCanUseTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDatetimePickerFileCanUseTime.MaxLength = 19;
            this.uiDatetimePickerFileCanUseTime.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiDatetimePickerFileCanUseTime.Name = "uiDatetimePickerFileCanUseTime";
            this.uiDatetimePickerFileCanUseTime.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiDatetimePickerFileCanUseTime.Size = new System.Drawing.Size(699, 29);
            this.uiDatetimePickerFileCanUseTime.SymbolDropDown = 61555;
            this.uiDatetimePickerFileCanUseTime.SymbolNormal = 61555;
            this.uiDatetimePickerFileCanUseTime.SymbolSize = 24;
            this.uiDatetimePickerFileCanUseTime.TabIndex = 8;
            this.uiDatetimePickerFileCanUseTime.Text = "2024-07-18 00:00:00";
            this.uiDatetimePickerFileCanUseTime.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiDatetimePickerFileCanUseTime.Value = new System.DateTime(2024, 7, 18, 0, 0, 0, 0);
            this.uiDatetimePickerFileCanUseTime.Watermark = "";
            this.uiDatetimePickerFileCanUseTime.WatermarkColor = System.Drawing.SystemColors.Highlight;
            // 
            // uiWaitingBarENC
            // 
            this.uiWaitingBarENC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiWaitingBarENC.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiWaitingBarENC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiWaitingBarENC.Location = new System.Drawing.Point(6, 647);
            this.uiWaitingBarENC.MinimumSize = new System.Drawing.Size(70, 23);
            this.uiWaitingBarENC.Name = "uiWaitingBarENC";
            this.uiWaitingBarENC.Size = new System.Drawing.Size(865, 29);
            this.uiWaitingBarENC.TabIndex = 10;
            this.uiWaitingBarENC.Text = "uiWaitingBarEnc";
            this.uiWaitingBarENC.Visible = false;
            // 
            // labelChooseTimeTip
            // 
            this.labelChooseTimeTip.AutoSize = true;
            this.labelChooseTimeTip.Location = new System.Drawing.Point(15, 296);
            this.labelChooseTimeTip.Name = "labelChooseTimeTip";
            this.labelChooseTimeTip.Size = new System.Drawing.Size(56, 17);
            this.labelChooseTimeTip.TabIndex = 7;
            this.labelChooseTimeTip.Text = "许可时间";
            // 
            // buttonChooseFileEnc
            // 
            this.buttonChooseFileEnc.ForeColor = System.Drawing.Color.Black;
            this.buttonChooseFileEnc.Location = new System.Drawing.Point(660, 78);
            this.buttonChooseFileEnc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonChooseFileEnc.Name = "buttonChooseFileEnc";
            this.buttonChooseFileEnc.Size = new System.Drawing.Size(132, 26);
            this.buttonChooseFileEnc.TabIndex = 1;
            this.buttonChooseFileEnc.Text = "选择文件";
            this.buttonChooseFileEnc.UseVisualStyleBackColor = true;
            this.buttonChooseFileEnc.Click += new System.EventHandler(this.buttonChooseFileEnc_Click);
            // 
            // textBoxFileLocationEnc
            // 
            this.textBoxFileLocationEnc.Location = new System.Drawing.Point(18, 78);
            this.textBoxFileLocationEnc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFileLocationEnc.Name = "textBoxFileLocationEnc";
            this.textBoxFileLocationEnc.ReadOnly = true;
            this.textBoxFileLocationEnc.Size = new System.Drawing.Size(626, 23);
            this.textBoxFileLocationEnc.TabIndex = 0;
            // 
            // labelChoosePasswordTipEnc
            // 
            this.labelChoosePasswordTipEnc.AutoSize = true;
            this.labelChoosePasswordTipEnc.ForeColor = System.Drawing.Color.Black;
            this.labelChoosePasswordTipEnc.Location = new System.Drawing.Point(15, 187);
            this.labelChoosePasswordTipEnc.Name = "labelChoosePasswordTipEnc";
            this.labelChoosePasswordTipEnc.Size = new System.Drawing.Size(32, 17);
            this.labelChoosePasswordTipEnc.TabIndex = 4;
            this.labelChoosePasswordTipEnc.Text = "密码";
            // 
            // buttonStartENC
            // 
            this.buttonStartENC.ForeColor = System.Drawing.Color.Black;
            this.buttonStartENC.Location = new System.Drawing.Point(6, 596);
            this.buttonStartENC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonStartENC.Name = "buttonStartENC";
            this.buttonStartENC.Size = new System.Drawing.Size(426, 46);
            this.buttonStartENC.TabIndex = 9;
            this.buttonStartENC.Text = "加密";
            this.buttonStartENC.UseVisualStyleBackColor = true;
            this.buttonStartENC.Click += new System.EventHandler(this.buttonStartENC_Click);
            // 
            // uiCheckBoxDisplayPasswordEnc
            // 
            this.uiCheckBoxDisplayPasswordEnc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBoxDisplayPasswordEnc.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiCheckBoxDisplayPasswordEnc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiCheckBoxDisplayPasswordEnc.Location = new System.Drawing.Point(692, 184);
            this.uiCheckBoxDisplayPasswordEnc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uiCheckBoxDisplayPasswordEnc.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBoxDisplayPasswordEnc.Name = "uiCheckBoxDisplayPasswordEnc";
            this.uiCheckBoxDisplayPasswordEnc.Size = new System.Drawing.Size(100, 23);
            this.uiCheckBoxDisplayPasswordEnc.TabIndex = 6;
            this.uiCheckBoxDisplayPasswordEnc.Text = "显示密码";
            this.uiCheckBoxDisplayPasswordEnc.CheckedChanged += new System.EventHandler(this.uiCheckBoxDisplayPassword_CheckedChanged);
            // 
            // textBoxInptPasswordEnc
            // 
            this.textBoxInptPasswordEnc.Location = new System.Drawing.Point(75, 184);
            this.textBoxInptPasswordEnc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxInptPasswordEnc.MaxLength = 25;
            this.textBoxInptPasswordEnc.Name = "textBoxInptPasswordEnc";
            this.textBoxInptPasswordEnc.Size = new System.Drawing.Size(569, 23);
            this.textBoxInptPasswordEnc.TabIndex = 5;
            this.textBoxInptPasswordEnc.UseSystemPasswordChar = true;
            // 
            // uiTabControlMenuMain
            // 
            this.uiTabControlMenuMain.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.uiTabControlMenuMain.Controls.Add(this.tabPageENC);
            this.uiTabControlMenuMain.Controls.Add(this.tabPageDEC);
            this.uiTabControlMenuMain.Controls.Add(this.tabPageZipFile);
            this.uiTabControlMenuMain.Controls.Add(this.tabPageAbout);
            this.uiTabControlMenuMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTabControlMenuMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControlMenuMain.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTabControlMenuMain.Location = new System.Drawing.Point(0, 0);
            this.uiTabControlMenuMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uiTabControlMenuMain.Multiline = true;
            this.uiTabControlMenuMain.Name = "uiTabControlMenuMain";
            this.uiTabControlMenuMain.SelectedIndex = 0;
            this.uiTabControlMenuMain.Size = new System.Drawing.Size(1078, 658);
            this.uiTabControlMenuMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControlMenuMain.TabIndex = 0;
            // 
            // openFileDialogAct
            // 
            this.openFileDialogAct.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 658);
            this.Controls.Add(this.uiTabControlMenuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1094, 697);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1094, 697);
            this.Name = "MainForm";
            this.Text = "SafeFile";
            this.tabPageAbout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAboutPicture)).EndInit();
            this.tabPageZipFile.ResumeLayout(false);
            this.tabPageZipFile.PerformLayout();
            this.tabPageDEC.ResumeLayout(false);
            this.groupBoxDec.ResumeLayout(false);
            this.groupBoxDec.PerformLayout();
            this.tabPageENC.ResumeLayout(false);
            this.groupBoxEnc.ResumeLayout(false);
            this.groupBoxEnc.PerformLayout();
            this.uiTabControlMenuMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIDatetimePicker uiDatetimePickerChooseTime;
        private System.Windows.Forms.TabPage tabPageAbout;
        private Sunny.UI.UITextBox uiTextBoxAboutText;
        private System.Windows.Forms.PictureBox pictureBoxAboutPicture;
        private System.Windows.Forms.TabPage tabPageZipFile;
        private System.Windows.Forms.Button buttonStartDecompression;
        private System.Windows.Forms.Button buttonChooseDecompressionFile;
        private System.Windows.Forms.TextBox textBoxdecompression;
        private System.Windows.Forms.TextBox textBoxDecompressionReturnPath;
        private System.Windows.Forms.TextBox textBoxZipfile;
        private System.Windows.Forms.TextBox textBoxZipReturnLoctain;
        private System.Windows.Forms.Button buttonChooseDecompressionReturn;
        private System.Windows.Forms.Button buttonStartZip;
        private System.Windows.Forms.Button buttonChooseZipFile;
        private System.Windows.Forms.Button buttonZipReturnLoctain;
        private System.Windows.Forms.TabPage tabPageDEC;
        private System.Windows.Forms.GroupBox groupBoxDec;
        private System.Windows.Forms.Button buttonDecCancel;
        private System.Windows.Forms.Button buttonChooseReturnFileLocationDec;
        private System.Windows.Forms.TextBox textBoxReturnFileLocationDEC;
        private Sunny.UI.UIWaitingBar uiWaitingBarDEC;
        private System.Windows.Forms.Button buttonStartDec;
        private System.Windows.Forms.Label labelPasswordTipDec;
        private Sunny.UI.UICheckBox uiCheckBoxDisplay;
        private System.Windows.Forms.TextBox textBoxpasswordDec;
        private System.Windows.Forms.Button buttonFileLocationDEC;
        private System.Windows.Forms.TextBox textBoxFileLocationDEC;
        private System.Windows.Forms.TabPage tabPageENC;
        private System.Windows.Forms.GroupBox groupBoxEnc;
        private System.Windows.Forms.Button buttonEncCanel;
        private System.Windows.Forms.Button buttonChooseReturnFileLocationEnc;
        private System.Windows.Forms.TextBox textBoxFileReturnLocationEnc;
        private Sunny.UI.UIDatetimePicker uiDatetimePickerFileCanUseTime;
        private Sunny.UI.UIWaitingBar uiWaitingBarENC;
        private System.Windows.Forms.Label labelChooseTimeTip;
        private System.Windows.Forms.Button buttonChooseFileEnc;
        private System.Windows.Forms.TextBox textBoxFileLocationEnc;
        private System.Windows.Forms.Label labelChoosePasswordTipEnc;
        private System.Windows.Forms.Button buttonStartENC;
        private Sunny.UI.UICheckBox uiCheckBoxDisplayPasswordEnc;
        private System.Windows.Forms.TextBox textBoxInptPasswordEnc;
        private Sunny.UI.UITabControlMenu uiTabControlMenuMain;
        private System.Windows.Forms.OpenFileDialog openFileDialogAct;
    }
}

