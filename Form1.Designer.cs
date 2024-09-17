namespace ESP_Flash
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comPorts = new ListBox();
            scanBtn = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            filesToFlash = new ListBox();
            searchFilesBtn = new Button();
            esptoolBtn = new Button();
            theFlashBin = new TextBox();
            label1 = new Label();
            theCOMPort = new TextBox();
            label2 = new Label();
            esptoolFile = new TextBox();
            label3 = new Label();
            FlashBtn = new Button();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            pShellWindow = new TextBox();
            groupBox5 = new GroupBox();
            espToolsFiles = new ListBox();
            theProgress = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // comPorts
            // 
            comPorts.FormattingEnabled = true;
            comPorts.ItemHeight = 15;
            comPorts.Location = new Point(6, 22);
            comPorts.Name = "comPorts";
            comPorts.Size = new Size(464, 94);
            comPorts.TabIndex = 0;
            comPorts.SelectedIndexChanged += comPorts_SelectedIndexChanged;
            // 
            // scanBtn
            // 
            scanBtn.Location = new Point(359, 127);
            scanBtn.Name = "scanBtn";
            scanBtn.Size = new Size(112, 23);
            scanBtn.TabIndex = 1;
            scanBtn.Text = "Re-Scan Ports";
            scanBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comPorts);
            groupBox1.Controls.Add(scanBtn);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(476, 156);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Available COM Ports";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(filesToFlash);
            groupBox2.Controls.Add(searchFilesBtn);
            groupBox2.Location = new Point(12, 174);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(476, 156);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Available Flash Files";
            // 
            // filesToFlash
            // 
            filesToFlash.FormattingEnabled = true;
            filesToFlash.ItemHeight = 15;
            filesToFlash.Location = new Point(10, 22);
            filesToFlash.Name = "filesToFlash";
            filesToFlash.Size = new Size(461, 94);
            filesToFlash.TabIndex = 6;
            filesToFlash.SelectedIndexChanged += filesToFlash_SelectedIndexChanged;
            // 
            // searchFilesBtn
            // 
            searchFilesBtn.Location = new Point(344, 122);
            searchFilesBtn.Name = "searchFilesBtn";
            searchFilesBtn.Size = new Size(127, 23);
            searchFilesBtn.TabIndex = 5;
            searchFilesBtn.Text = "Search FLASH Files";
            searchFilesBtn.UseVisualStyleBackColor = true;
            searchFilesBtn.Click += searchFilesBtn_Click;
            // 
            // esptoolBtn
            // 
            esptoolBtn.Location = new Point(329, 122);
            esptoolBtn.Name = "esptoolBtn";
            esptoolBtn.Size = new Size(141, 23);
            esptoolBtn.TabIndex = 10;
            esptoolBtn.Text = "Select esptool Folder";
            esptoolBtn.UseVisualStyleBackColor = true;
            esptoolBtn.Click += esptoolBtn_Click;
            // 
            // theFlashBin
            // 
            theFlashBin.Location = new Point(20, 81);
            theFlashBin.Name = "theFlashBin";
            theFlashBin.ReadOnly = true;
            theFlashBin.Size = new Size(450, 23);
            theFlashBin.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 61);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 6;
            label1.Text = "Selected Flash File";
            // 
            // theCOMPort
            // 
            theCOMPort.Location = new Point(20, 35);
            theCOMPort.Name = "theCOMPort";
            theCOMPort.ReadOnly = true;
            theCOMPort.Size = new Size(450, 23);
            theCOMPort.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 17);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 8;
            label2.Text = "COM Port To Use";
            // 
            // esptoolFile
            // 
            esptoolFile.Location = new Point(20, 127);
            esptoolFile.Name = "esptoolFile";
            esptoolFile.ReadOnly = true;
            esptoolFile.Size = new Size(450, 23);
            esptoolFile.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 107);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 10;
            label3.Text = "Select esptool Folder";
            // 
            // FlashBtn
            // 
            FlashBtn.Location = new Point(289, 150);
            FlashBtn.Name = "FlashBtn";
            FlashBtn.Size = new Size(181, 23);
            FlashBtn.TabIndex = 11;
            FlashBtn.Text = "Flash ESP";
            FlashBtn.UseVisualStyleBackColor = true;
            FlashBtn.Click += FlashBtn_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(esptoolFile);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(theCOMPort);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(theFlashBin);
            groupBox3.Location = new Point(12, 498);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(476, 171);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "ESP Flashing Variables";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(theProgress);
            groupBox4.Controls.Add(pShellWindow);
            groupBox4.Controls.Add(FlashBtn);
            groupBox4.Location = new Point(12, 675);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(476, 179);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            groupBox4.Text = "FLASH ESP Control";
            // 
            // pShellWindow
            // 
            pShellWindow.BackColor = SystemColors.HotTrack;
            pShellWindow.ForeColor = Color.White;
            pShellWindow.Location = new Point(9, 34);
            pShellWindow.Multiline = true;
            pShellWindow.Name = "pShellWindow";
            pShellWindow.ScrollBars = ScrollBars.Both;
            pShellWindow.Size = new Size(461, 110);
            pShellWindow.TabIndex = 12;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(esptoolBtn);
            groupBox5.Controls.Add(espToolsFiles);
            groupBox5.Location = new Point(12, 336);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(476, 156);
            groupBox5.TabIndex = 14;
            groupBox5.TabStop = false;
            groupBox5.Text = "Available Flash Files";
            // 
            // espToolsFiles
            // 
            espToolsFiles.FormattingEnabled = true;
            espToolsFiles.ItemHeight = 15;
            espToolsFiles.Location = new Point(10, 22);
            espToolsFiles.Name = "espToolsFiles";
            espToolsFiles.Size = new Size(461, 94);
            espToolsFiles.TabIndex = 6;
            espToolsFiles.SelectedIndexChanged += espToolsFiles_SelectedIndexChanged;
            // 
            // theProgress
            // 
            theProgress.AutoSize = true;
            theProgress.Location = new Point(10, 150);
            theProgress.Name = "theProgress";
            theProgress.Size = new Size(43, 15);
            theProgress.TabIndex = 13;
            theProgress.Text = "READY";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 875);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ESPTool GUI Flasher";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox comPorts;
        private Button scanBtn;
        private ListBox flashFiles;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button searchFilesBtn;
        private ListBox filesToFlash;
        private TextBox theFlashBin;
        private Label label1;
        private TextBox theCOMPort;
        private Label label2;
        private TextBox esptoolFile;
        private Button esptoolBtn;
        private Label label3;
        private Button FlashBtn;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Button button1;
        private ListBox espToolsFiles;
        private Button button2;
        private TextBox pShellWindow;
        private Label theProgress;
    }
}
