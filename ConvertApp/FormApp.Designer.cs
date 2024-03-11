namespace ConvertApp
{
    partial class FormApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApp));
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblC1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblProcess = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.TabConvertMP = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxConvert = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.TabResize = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxHiRes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnHiResFile = new System.Windows.Forms.Button();
            this.btnHiResBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBarHiRes = new System.Windows.Forms.ProgressBar();
            this.txtFilePathHiRes = new System.Windows.Forms.TextBox();
            this.TabConvertimage = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxConvertImage = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnImageConvert = new System.Windows.Forms.Button();
            this.btnImageBrowse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBarImage = new System.Windows.Forms.ProgressBar();
            this.txtFilePathImage = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ofdHiRes = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.tabControl.SuspendLayout();
            this.TabConvertMP.SuspendLayout();
            this.TabResize.SuspendLayout();
            this.TabConvertimage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(40, 7);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 28);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(45, 43);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(750, 23);
            this.txtFilePath.TabIndex = 3;
            // 
            // lblC1
            // 
            this.lblC1.AutoSize = true;
            this.lblC1.Location = new System.Drawing.Point(147, 13);
            this.lblC1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblC1.Name = "lblC1";
            this.lblC1.Size = new System.Drawing.Size(89, 17);
            this.lblC1.TabIndex = 4;
            this.lblC1.Text = "กรุณาเลือกไฟล์";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(45, 159);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(750, 28);
            this.progressBar.TabIndex = 5;
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.Location = new System.Drawing.Point(42, 138);
            this.lblProcess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(89, 17);
            this.lblProcess.TabIndex = 6;
            this.lblProcess.Text = "ข้อมูลดาวโหลด";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.TabConvertMP);
            this.tabControl.Controls.Add(this.TabResize);
            this.tabControl.Controls.Add(this.TabConvertimage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(829, 401);
            this.tabControl.TabIndex = 8;
            // 
            // TabConvertMP
            // 
            this.TabConvertMP.AutoScroll = true;
            this.TabConvertMP.BackColor = System.Drawing.Color.Gainsboro;
            this.TabConvertMP.Controls.Add(this.label1);
            this.TabConvertMP.Controls.Add(this.cbxConvert);
            this.TabConvertMP.Controls.Add(this.btnExit);
            this.TabConvertMP.Controls.Add(this.btnCancel);
            this.TabConvertMP.Controls.Add(this.btnConvert);
            this.TabConvertMP.Controls.Add(this.btnBrowse);
            this.TabConvertMP.Controls.Add(this.lblC1);
            this.TabConvertMP.Controls.Add(this.progressBar);
            this.TabConvertMP.Controls.Add(this.lblProcess);
            this.TabConvertMP.Controls.Add(this.txtFilePath);
            this.TabConvertMP.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TabConvertMP.Location = new System.Drawing.Point(4, 25);
            this.TabConvertMP.Name = "TabConvertMP";
            this.TabConvertMP.Padding = new System.Windows.Forms.Padding(3);
            this.TabConvertMP.Size = new System.Drawing.Size(821, 372);
            this.TabConvertMP.TabIndex = 0;
            this.TabConvertMP.Text = "ระบบจัดการเสียง";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "เลือกรูปแบบ";
            // 
            // cbxConvert
            // 
            this.cbxConvert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxConvert.FormattingEnabled = true;
            this.cbxConvert.Items.AddRange(new object[] {
            "MP3",
            "WAV"});
            this.cbxConvert.Location = new System.Drawing.Point(45, 95);
            this.cbxConvert.Name = "cbxConvert";
            this.cbxConvert.Size = new System.Drawing.Size(180, 24);
            this.cbxConvert.TabIndex = 12;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(700, 325);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 30);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "ออก";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(525, 325);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "เคลีย";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(340, 325);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(4);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(100, 30);
            this.btnConvert.TabIndex = 8;
            this.btnConvert.Text = "แปลง";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // TabResize
            // 
            this.TabResize.BackColor = System.Drawing.Color.Gainsboro;
            this.TabResize.Controls.Add(this.label7);
            this.TabResize.Controls.Add(this.cbxHiRes);
            this.TabResize.Controls.Add(this.label3);
            this.TabResize.Controls.Add(this.button1);
            this.TabResize.Controls.Add(this.button2);
            this.TabResize.Controls.Add(this.btnHiResFile);
            this.TabResize.Controls.Add(this.btnHiResBrowse);
            this.TabResize.Controls.Add(this.label2);
            this.TabResize.Controls.Add(this.progressBarHiRes);
            this.TabResize.Controls.Add(this.txtFilePathHiRes);
            this.TabResize.Location = new System.Drawing.Point(4, 25);
            this.TabResize.Name = "TabResize";
            this.TabResize.Padding = new System.Windows.Forms.Padding(3);
            this.TabResize.Size = new System.Drawing.Size(847, 419);
            this.TabResize.TabIndex = 1;
            this.TabResize.Text = "HiRes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "เลือกรูปแบบ";
            // 
            // cbxHiRes
            // 
            this.cbxHiRes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHiRes.FormattingEnabled = true;
            this.cbxHiRes.Items.AddRange(new object[] {
            "44.1  kHz",
            "96 kHz",
            "192 kHz"});
            this.cbxHiRes.Location = new System.Drawing.Point(45, 95);
            this.cbxHiRes.Name = "cbxHiRes";
            this.cbxHiRes.Size = new System.Drawing.Size(180, 24);
            this.cbxHiRes.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "ข้อมูลดาวโหลด";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(700, 325);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 17;
            this.button1.Text = "ออก";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(525, 325);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 16;
            this.button2.Text = "เคลีย";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnHiResFile
            // 
            this.btnHiResFile.Location = new System.Drawing.Point(340, 325);
            this.btnHiResFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnHiResFile.Name = "btnHiResFile";
            this.btnHiResFile.Size = new System.Drawing.Size(100, 30);
            this.btnHiResFile.TabIndex = 15;
            this.btnHiResFile.Text = "HiRes";
            this.btnHiResFile.UseVisualStyleBackColor = true;
            this.btnHiResFile.Click += new System.EventHandler(this.btnHiResFile_Click);
            // 
            // btnHiResBrowse
            // 
            this.btnHiResBrowse.Location = new System.Drawing.Point(40, 7);
            this.btnHiResBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnHiResBrowse.Name = "btnHiResBrowse";
            this.btnHiResBrowse.Size = new System.Drawing.Size(100, 28);
            this.btnHiResBrowse.TabIndex = 11;
            this.btnHiResBrowse.Text = "Browse";
            this.btnHiResBrowse.UseVisualStyleBackColor = true;
            this.btnHiResBrowse.Click += new System.EventHandler(this.btnHiResBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "กรุณาเลือกไฟล์";
            // 
            // progressBarHiRes
            // 
            this.progressBarHiRes.Location = new System.Drawing.Point(45, 159);
            this.progressBarHiRes.Margin = new System.Windows.Forms.Padding(4);
            this.progressBarHiRes.Name = "progressBarHiRes";
            this.progressBarHiRes.Size = new System.Drawing.Size(750, 28);
            this.progressBarHiRes.TabIndex = 14;
            // 
            // txtFilePathHiRes
            // 
            this.txtFilePathHiRes.Location = new System.Drawing.Point(45, 43);
            this.txtFilePathHiRes.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilePathHiRes.Name = "txtFilePathHiRes";
            this.txtFilePathHiRes.ReadOnly = true;
            this.txtFilePathHiRes.Size = new System.Drawing.Size(750, 23);
            this.txtFilePathHiRes.TabIndex = 12;
            // 
            // TabConvertimage
            // 
            this.TabConvertimage.BackColor = System.Drawing.Color.Gainsboro;
            this.TabConvertimage.Controls.Add(this.label6);
            this.TabConvertimage.Controls.Add(this.cbxConvertImage);
            this.TabConvertimage.Controls.Add(this.label4);
            this.TabConvertimage.Controls.Add(this.button3);
            this.TabConvertimage.Controls.Add(this.button4);
            this.TabConvertimage.Controls.Add(this.btnImageConvert);
            this.TabConvertimage.Controls.Add(this.btnImageBrowse);
            this.TabConvertimage.Controls.Add(this.label5);
            this.TabConvertimage.Controls.Add(this.progressBarImage);
            this.TabConvertimage.Controls.Add(this.txtFilePathImage);
            this.TabConvertimage.Location = new System.Drawing.Point(4, 25);
            this.TabConvertimage.Name = "TabConvertimage";
            this.TabConvertimage.Size = new System.Drawing.Size(847, 419);
            this.TabConvertimage.TabIndex = 3;
            this.TabConvertimage.Text = "แปลงรูปภาพ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "เลือกรูปแบบ";
            // 
            // cbxConvertImage
            // 
            this.cbxConvertImage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxConvertImage.FormattingEnabled = true;
            this.cbxConvertImage.Items.AddRange(new object[] {
            "webp",
            "jpg",
            "jpeg",
            "png",
            "svg",
            "avif",
            "heic"});
            this.cbxConvertImage.Location = new System.Drawing.Point(45, 95);
            this.cbxConvertImage.Name = "cbxConvertImage";
            this.cbxConvertImage.Size = new System.Drawing.Size(180, 24);
            this.cbxConvertImage.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "ข้อมูลดาวโหลด";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(700, 325);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 30);
            this.button3.TabIndex = 25;
            this.button3.Text = "ออก";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(525, 325);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 30);
            this.button4.TabIndex = 24;
            this.button4.Text = "เคลีย";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnImageConvert
            // 
            this.btnImageConvert.Location = new System.Drawing.Point(340, 325);
            this.btnImageConvert.Margin = new System.Windows.Forms.Padding(4);
            this.btnImageConvert.Name = "btnImageConvert";
            this.btnImageConvert.Size = new System.Drawing.Size(100, 30);
            this.btnImageConvert.TabIndex = 23;
            this.btnImageConvert.Text = "แปลงรูปถาพ";
            this.btnImageConvert.UseVisualStyleBackColor = true;
            this.btnImageConvert.Click += new System.EventHandler(this.btnImageConvert_Click);
            // 
            // btnImageBrowse
            // 
            this.btnImageBrowse.Location = new System.Drawing.Point(40, 7);
            this.btnImageBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnImageBrowse.Name = "btnImageBrowse";
            this.btnImageBrowse.Size = new System.Drawing.Size(100, 28);
            this.btnImageBrowse.TabIndex = 19;
            this.btnImageBrowse.Text = "Browse";
            this.btnImageBrowse.UseVisualStyleBackColor = true;
            this.btnImageBrowse.Click += new System.EventHandler(this.btnImageBrowse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "กรุณาเลือกไฟล์";
            // 
            // progressBarImage
            // 
            this.progressBarImage.Location = new System.Drawing.Point(45, 159);
            this.progressBarImage.Margin = new System.Windows.Forms.Padding(4);
            this.progressBarImage.Name = "progressBarImage";
            this.progressBarImage.Size = new System.Drawing.Size(750, 28);
            this.progressBarImage.TabIndex = 22;
            // 
            // txtFilePathImage
            // 
            this.txtFilePathImage.Location = new System.Drawing.Point(45, 43);
            this.txtFilePathImage.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilePathImage.Name = "txtFilePathImage";
            this.txtFilePathImage.ReadOnly = true;
            this.txtFilePathImage.Size = new System.Drawing.Size(750, 23);
            this.txtFilePathImage.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 29);
            this.panel1.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(829, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingToolStripMenuItem.Text = "Setting";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(829, 401);
            this.panel2.TabIndex = 10;
            // 
            // ofdHiRes
            // 
            this.ofdHiRes.Filter = "MP3 files (*.mp3)|*.mp3";
            // 
            // ofdImage
            // 
            this.ofdImage.Filter = "WebP Files (*.webp)|*.webp|JPEG Files (*.jpg, *.jpeg)|*.jpg;*.jpeg|PNG Files (*.p" +
    "ng)|*.png|SVG Files (*.svg)|*.svg|HEIF/AVIF Files (*.avif)|*.avif|HEIF/HEIC File" +
    "s (*.heic)|*.heic";
            // 
            // FormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 430);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "โปรแกรมจัดการจิปะถะ (Pethzero)";
            this.tabControl.ResumeLayout(false);
            this.TabConvertMP.ResumeLayout(false);
            this.TabConvertMP.PerformLayout();
            this.TabResize.ResumeLayout(false);
            this.TabResize.PerformLayout();
            this.TabConvertimage.ResumeLayout(false);
            this.TabConvertimage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblC1;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.TabPage TabConvertMP;
        private System.Windows.Forms.TabPage TabResize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxConvert;
        public System.Windows.Forms.TextBox txtFilePath;
        public System.Windows.Forms.Button btnConvert;
        protected internal System.Windows.Forms.Button btnBrowse;
        protected internal System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button btnHiResFile;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtFilePathHiRes;
        private System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.Button btnHiResBrowse;
        public System.Windows.Forms.OpenFileDialog ofdHiRes;
        public System.Windows.Forms.ProgressBar progressBarHiRes;
        private System.Windows.Forms.TabPage TabConvertimage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button btnImageConvert;
        public System.Windows.Forms.Button btnImageBrowse;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ProgressBar progressBarImage;
        public System.Windows.Forms.TextBox txtFilePathImage;
        public System.Windows.Forms.OpenFileDialog ofdImage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxConvertImage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxHiRes;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
    }
}

