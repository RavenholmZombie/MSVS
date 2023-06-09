namespace WinFormsApp1
{
    partial class frmMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            pBoxSkin = new PictureBox();
            label1 = new Label();
            dialog = new SaveFileDialog();
            panel1 = new Panel();
            groupRenders = new DarkUI.Controls.DarkGroupBox();
            radioHead = new DarkUI.Controls.DarkRadioButton();
            radioFace = new DarkUI.Controls.DarkRadioButton();
            radioIso = new DarkUI.Controls.DarkRadioButton();
            radioSkin = new DarkUI.Controls.DarkRadioButton();
            textboxUsername = new DarkUI.Controls.DarkTextBox();
            btnShow = new DarkUI.Controls.DarkButton();
            btnDownload = new DarkUI.Controls.DarkButton();
            toolTip = new ToolTip(components);
            darkMenuStrip1 = new DarkUI.Controls.DarkMenuStrip();
            aboutToolStripMenuItem2 = new ToolStripMenuItem();
            aboutToolStripMenuItem3 = new ToolStripMenuItem();
            showInfoAboutUSERToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            poweredByMCHeadsnetToolStripMenuItem1 = new ToolStripMenuItem();
            useThisSkinToolStripMenuItem1 = new ToolStripMenuItem();
            updateAvailableToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pBoxSkin).BeginInit();
            panel1.SuspendLayout();
            groupRenders.SuspendLayout();
            darkMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pBoxSkin
            // 
            pBoxSkin.BackColor = Color.Transparent;
            pBoxSkin.BackgroundImageLayout = ImageLayout.Stretch;
            pBoxSkin.ErrorImage = Minecraft_Skin_Viewer_and_Stealer.Properties.Resources.error;
            pBoxSkin.InitialImage = Minecraft_Skin_Viewer_and_Stealer.Properties.Resources.MHF_Steve;
            pBoxSkin.Location = new Point(106, 50);
            pBoxSkin.Name = "pBoxSkin";
            pBoxSkin.Size = new Size(86, 199);
            pBoxSkin.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxSkin.TabIndex = 0;
            pBoxSkin.TabStop = false;
            pBoxSkin.WaitOnLoad = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(26, 16);
            label1.Name = "label1";
            label1.Size = new Size(180, 15);
            label1.TabIndex = 1;
            label1.Text = "Enter a username or player UUID:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.BackgroundImage = Minecraft_Skin_Viewer_and_Stealer.Properties.Resources.darkBack;
            panel1.Controls.Add(groupRenders);
            panel1.Controls.Add(textboxUsername);
            panel1.Controls.Add(btnShow);
            panel1.Controls.Add(btnDownload);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 263);
            panel1.Name = "panel1";
            panel1.Size = new Size(301, 165);
            panel1.TabIndex = 6;
            // 
            // groupRenders
            // 
            groupRenders.BorderColor = Color.FromArgb(51, 51, 51);
            groupRenders.Controls.Add(radioHead);
            groupRenders.Controls.Add(radioFace);
            groupRenders.Controls.Add(radioIso);
            groupRenders.Controls.Add(radioSkin);
            groupRenders.Location = new Point(26, 65);
            groupRenders.Name = "groupRenders";
            groupRenders.Size = new Size(249, 57);
            groupRenders.TabIndex = 9;
            groupRenders.TabStop = false;
            groupRenders.Text = "Download Options:";
            // 
            // radioHead
            // 
            radioHead.AutoSize = true;
            radioHead.Location = new Point(189, 22);
            radioHead.Name = "radioHead";
            radioHead.Size = new Size(53, 19);
            radioHead.TabIndex = 13;
            radioHead.TabStop = true;
            radioHead.Text = "Head";
            radioHead.CheckedChanged += radioHead_CheckedChanged_1;
            // 
            // radioFace
            // 
            radioFace.AutoSize = true;
            radioFace.Location = new Point(134, 22);
            radioFace.Name = "radioFace";
            radioFace.Size = new Size(49, 19);
            radioFace.TabIndex = 12;
            radioFace.TabStop = true;
            radioFace.Text = "Face";
            radioFace.CheckedChanged += radioFace_CheckedChanged_1;
            // 
            // radioIso
            // 
            radioIso.AutoSize = true;
            radioIso.Location = new Point(60, 22);
            radioIso.Name = "radioIso";
            radioIso.Size = new Size(74, 19);
            radioIso.TabIndex = 11;
            radioIso.TabStop = true;
            radioIso.Text = "Isometric";
            radioIso.CheckedChanged += radioIso_CheckedChanged_1;
            // 
            // radioSkin
            // 
            radioSkin.AutoSize = true;
            radioSkin.Location = new Point(7, 22);
            radioSkin.Name = "radioSkin";
            radioSkin.Size = new Size(47, 19);
            radioSkin.TabIndex = 10;
            radioSkin.TabStop = true;
            radioSkin.Text = "Skin";
            radioSkin.CheckedChanged += radioSkin_CheckedChanged_1;
            // 
            // textboxUsername
            // 
            textboxUsername.AcceptsReturn = true;
            textboxUsername.BackColor = Color.FromArgb(69, 73, 74);
            textboxUsername.BorderStyle = BorderStyle.FixedSingle;
            textboxUsername.ForeColor = Color.FromArgb(220, 220, 220);
            textboxUsername.Location = new Point(26, 36);
            textboxUsername.Name = "textboxUsername";
            textboxUsername.PlaceholderText = "e.g. Dinnerbone";
            textboxUsername.Size = new Size(249, 23);
            textboxUsername.TabIndex = 8;
            textboxUsername.TextChanged += darkTextBox1_TextChanged;
            textboxUsername.KeyPress += textboxUsername_KeyPress;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(200, 128);
            btnShow.Name = "btnShow";
            btnShow.Padding = new Padding(5);
            btnShow.Size = new Size(75, 23);
            btnShow.TabIndex = 7;
            btnShow.Text = "Show";
            btnShow.Click += darkButton2_Click;
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(26, 128);
            btnDownload.Name = "btnDownload";
            btnDownload.Padding = new Padding(5);
            btnDownload.Size = new Size(168, 23);
            btnDownload.TabIndex = 6;
            btnDownload.Text = "Download Skin";
            btnDownload.Click += darkButton1_Click;
            // 
            // darkMenuStrip1
            // 
            darkMenuStrip1.BackColor = Color.FromArgb(60, 63, 65);
            darkMenuStrip1.ForeColor = Color.FromArgb(220, 220, 220);
            darkMenuStrip1.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem2, useThisSkinToolStripMenuItem1, updateAvailableToolStripMenuItem });
            darkMenuStrip1.Location = new Point(0, 0);
            darkMenuStrip1.Name = "darkMenuStrip1";
            darkMenuStrip1.Padding = new Padding(3, 2, 0, 2);
            darkMenuStrip1.Size = new Size(301, 24);
            darkMenuStrip1.TabIndex = 7;
            darkMenuStrip1.Text = "darkMenuStrip1";
            // 
            // aboutToolStripMenuItem2
            // 
            aboutToolStripMenuItem2.BackColor = Color.FromArgb(60, 63, 65);
            aboutToolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem3, showInfoAboutUSERToolStripMenuItem, exitToolStripMenuItem1, toolStripSeparator2, poweredByMCHeadsnetToolStripMenuItem1 });
            aboutToolStripMenuItem2.ForeColor = Color.FromArgb(220, 220, 220);
            aboutToolStripMenuItem2.Name = "aboutToolStripMenuItem2";
            aboutToolStripMenuItem2.Size = new Size(52, 20);
            aboutToolStripMenuItem2.Text = "About";
            // 
            // aboutToolStripMenuItem3
            // 
            aboutToolStripMenuItem3.BackColor = Color.FromArgb(60, 63, 65);
            aboutToolStripMenuItem3.ForeColor = Color.FromArgb(220, 220, 220);
            aboutToolStripMenuItem3.Image = Minecraft_Skin_Viewer_and_Stealer.Properties.Resources.information;
            aboutToolStripMenuItem3.Name = "aboutToolStripMenuItem3";
            aboutToolStripMenuItem3.Size = new Size(216, 22);
            aboutToolStripMenuItem3.Text = "About";
            aboutToolStripMenuItem3.Click += aboutToolStripMenuItem3_Click;
            // 
            // showInfoAboutUSERToolStripMenuItem
            // 
            showInfoAboutUSERToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            showInfoAboutUSERToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            showInfoAboutUSERToolStripMenuItem.Image = Minecraft_Skin_Viewer_and_Stealer.Properties.Resources.logo_nmc;
            showInfoAboutUSERToolStripMenuItem.Name = "showInfoAboutUSERToolStripMenuItem";
            showInfoAboutUSERToolStripMenuItem.Size = new Size(216, 22);
            showInfoAboutUSERToolStripMenuItem.Text = "Show info about USER";
            showInfoAboutUSERToolStripMenuItem.Click += showInfoAboutUSERToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.BackColor = Color.FromArgb(60, 63, 65);
            exitToolStripMenuItem1.ForeColor = Color.FromArgb(220, 220, 220);
            exitToolStripMenuItem1.Image = Minecraft_Skin_Viewer_and_Stealer.Properties.Resources.door_out;
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(216, 22);
            exitToolStripMenuItem1.Text = "Exit";
            exitToolStripMenuItem1.Click += exitToolStripMenuItem1_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.BackColor = Color.FromArgb(60, 63, 65);
            toolStripSeparator2.ForeColor = Color.FromArgb(220, 220, 220);
            toolStripSeparator2.Margin = new Padding(0, 0, 0, 1);
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(213, 6);
            // 
            // poweredByMCHeadsnetToolStripMenuItem1
            // 
            poweredByMCHeadsnetToolStripMenuItem1.BackColor = Color.FromArgb(60, 63, 65);
            poweredByMCHeadsnetToolStripMenuItem1.ForeColor = Color.FromArgb(220, 220, 220);
            poweredByMCHeadsnetToolStripMenuItem1.Image = Minecraft_Skin_Viewer_and_Stealer.Properties.Resources.c5ef3347_4593_4f39_8bb1_2eaa40dd986e;
            poweredByMCHeadsnetToolStripMenuItem1.Name = "poweredByMCHeadsnetToolStripMenuItem1";
            poweredByMCHeadsnetToolStripMenuItem1.Size = new Size(216, 22);
            poweredByMCHeadsnetToolStripMenuItem1.Text = "Powered by MC-Heads.net";
            poweredByMCHeadsnetToolStripMenuItem1.Click += poweredByMCHeadsnetToolStripMenuItem1_Click;
            // 
            // useThisSkinToolStripMenuItem1
            // 
            useThisSkinToolStripMenuItem1.BackColor = Color.FromArgb(60, 63, 65);
            useThisSkinToolStripMenuItem1.ForeColor = Color.FromArgb(220, 220, 220);
            useThisSkinToolStripMenuItem1.Name = "useThisSkinToolStripMenuItem1";
            useThisSkinToolStripMenuItem1.Size = new Size(85, 20);
            useThisSkinToolStripMenuItem1.Text = "Use this Skin";
            useThisSkinToolStripMenuItem1.Click += useThisSkinToolStripMenuItem1_Click;
            // 
            // updateAvailableToolStripMenuItem
            // 
            updateAvailableToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            updateAvailableToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            updateAvailableToolStripMenuItem.Image = Minecraft_Skin_Viewer_and_Stealer.Properties.Resources.information;
            updateAvailableToolStripMenuItem.Name = "updateAvailableToolStripMenuItem";
            updateAvailableToolStripMenuItem.Size = new Size(124, 20);
            updateAvailableToolStripMenuItem.Text = "Update Available";
            updateAvailableToolStripMenuItem.Visible = false;
            updateAvailableToolStripMenuItem.Click += updateAvailableToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            BackgroundImage = Minecraft_Skin_Viewer_and_Stealer.Properties.Resources._2023_01_14_13_37_21;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(301, 428);
            Controls.Add(panel1);
            Controls.Add(pBoxSkin);
            Controls.Add(darkMenuStrip1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Minecraft Skin Viewer and Stealer";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pBoxSkin).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupRenders.ResumeLayout(false);
            groupRenders.PerformLayout();
            darkMenuStrip1.ResumeLayout(false);
            darkMenuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pBoxSkin;
        private Label label1;
        private SaveFileDialog dialog;
        private Panel panel1;
        private ToolTip toolTip;
        private DarkUI.Controls.DarkButton btnDownload;
        private DarkUI.Controls.DarkButton btnShow;
        private DarkUI.Controls.DarkTextBox textboxUsername;
        private DarkUI.Controls.DarkGroupBox groupRenders;
        private DarkUI.Controls.DarkRadioButton radioSkin;
        private DarkUI.Controls.DarkRadioButton radioIso;
        private DarkUI.Controls.DarkRadioButton radioFace;
        private DarkUI.Controls.DarkRadioButton radioHead;
        private DarkUI.Controls.DarkMenuStrip darkMenuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem2;
        private ToolStripMenuItem aboutToolStripMenuItem3;
        private ToolStripMenuItem showInfoAboutUSERToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem poweredByMCHeadsnetToolStripMenuItem1;
        private ToolStripMenuItem useThisSkinToolStripMenuItem1;
        private ToolStripMenuItem updateAvailableToolStripMenuItem;
    }
}