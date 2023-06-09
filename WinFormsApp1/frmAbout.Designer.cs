namespace Minecraft_Skin_Viewer_and_Stealer
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lblVersion = new Label();
            pictureBox2 = new PictureBox();
            tabPage2 = new TabPage();
            richTextBox1 = new RichTextBox();
            tabPage3 = new TabPage();
            groupBox1 = new GroupBox();
            richTextBox2 = new RichTextBox();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabPage4 = new TabPage();
            label3 = new Label();
            progressBar1 = new ProgressBar();
            groupBox2 = new GroupBox();
            btnDownload = new Button();
            btnCheck = new Button();
            lblNewerVersion = new Label();
            lblCurrentVersion = new Label();
            button1 = new Button();
            sfd = new SaveFileDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage4.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(393, 264);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = Properties.Resources._2023_01_13_20_041;
            tabPage1.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage1.BorderStyle = BorderStyle.FixedSingle;
            tabPage1.Controls.Add(lblVersion);
            tabPage1.Controls.Add(pictureBox2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(385, 236);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "About";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblVersion.ForeColor = Color.White;
            lblVersion.Location = new Point(126, 134);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(130, 30);
            lblVersion.TabIndex = 1;
            lblVersion.Text = "Version 1.0.0";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Minecraft_Skin_Viewer_an;
            pictureBox2.Location = new Point(20, 70);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(342, 17);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.BorderStyle = BorderStyle.FixedSingle;
            tabPage2.Controls.Add(richTextBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(385, 236);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "License";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.White;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(3, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(377, 228);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // tabPage3
            // 
            tabPage3.BorderStyle = BorderStyle.FixedSingle;
            tabPage3.Controls.Add(groupBox1);
            tabPage3.Controls.Add(panel1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(385, 236);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Credits";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBox2);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(3, 112);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(377, 119);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Additional Credits:";
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.White;
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Dock = DockStyle.Fill;
            richTextBox2.Location = new Point(3, 19);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(371, 97);
            richTextBox2.TabIndex = 0;
            richTextBox2.Text = "MC-Heads\nFor their Minecraft skins API.\n\nNameMC\nFor their player lookup API.\n";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(91, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 29);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Developer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(49, 7);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 1;
            label1.Text = "RavenholmZombie";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.ImageLocation = "https://mc-heads.net/body/RavenholmZombie";
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label3);
            tabPage4.Controls.Add(progressBar1);
            tabPage4.Controls.Add(groupBox2);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(385, 236);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Updates";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 192);
            label3.Name = "label3";
            label3.Size = new Size(198, 15);
            label3.TabIndex = 2;
            label3.Text = "Downloading latest GitHub release...";
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Bottom;
            progressBar1.Location = new Point(3, 210);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(379, 23);
            progressBar1.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDownload);
            groupBox2.Controls.Add(btnCheck);
            groupBox2.Controls.Add(lblNewerVersion);
            groupBox2.Controls.Add(lblCurrentVersion);
            groupBox2.Location = new Point(85, 54);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(215, 118);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Updater";
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(6, 86);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(75, 23);
            btnDownload.TabIndex = 3;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(134, 86);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(75, 23);
            btnCheck.TabIndex = 1;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // lblNewerVersion
            // 
            lblNewerVersion.AutoSize = true;
            lblNewerVersion.Location = new Point(17, 55);
            lblNewerVersion.Name = "lblNewerVersion";
            lblNewerVersion.Size = new Size(137, 15);
            lblNewerVersion.TabIndex = 2;
            lblNewerVersion.Text = "Please check for updates";
            // 
            // lblCurrentVersion
            // 
            lblCurrentVersion.AutoSize = true;
            lblCurrentVersion.Location = new Point(17, 29);
            lblCurrentVersion.Name = "lblCurrentVersion";
            lblCurrentVersion.Size = new Size(102, 15);
            lblCurrentVersion.TabIndex = 1;
            lblCurrentVersion.Text = "Your version: 1.0.7";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(306, 273);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 305);
            Controls.Add(button1);
            Controls.Add(tabControl1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAbout";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "About Minecraft Skin Viewer and Stealer";
            Load += frmAbout_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button1;
        private TabPage tabPage3;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private RichTextBox richTextBox2;
        private PictureBox pictureBox2;
        private Label lblVersion;
        private TabPage tabPage4;
        private GroupBox groupBox2;
        private Label lblNewerVersion;
        private Label lblCurrentVersion;
        private Button btnDownload;
        public TabControl tabControl1;
        public Button btnCheck;
        private ProgressBar progressBar1;
        private Label label3;
        private SaveFileDialog sfd;
    }
}