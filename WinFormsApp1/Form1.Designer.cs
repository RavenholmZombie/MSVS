namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pBoxSkin = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.poweredByMCHeadsnetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useThisSkinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uA = new System.Windows.Forms.ToolStripMenuItem();
            this.dialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSkin)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBoxSkin
            // 
            this.pBoxSkin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxSkin.ErrorImage = global::Minecraft_Skin_Viewer_and_Stealer.Properties.Resources.error;
            this.pBoxSkin.InitialImage = global::Minecraft_Skin_Viewer_and_Stealer.Properties.Resources.MHF_Steve;
            this.pBoxSkin.Location = new System.Drawing.Point(102, 40);
            this.pBoxSkin.Name = "pBoxSkin";
            this.pBoxSkin.Size = new System.Drawing.Size(86, 199);
            this.pBoxSkin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxSkin.TabIndex = 0;
            this.pBoxSkin.TabStop = false;
            this.pBoxSkin.WaitOnLoad = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter a username or player UUID:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 279);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "e.g.: CSX8600";
            this.textBox1.Size = new System.Drawing.Size(235, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(148, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(67, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Download";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.useThisSkinToolStripMenuItem,
            this.uA});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(291, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1,
            this.exitToolStripMenuItem,
            this.toolStripSeparator1,
            this.poweredByMCHeadsnetToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Image = global::Minecraft_Skin_Viewer_and_Stealer.Properties.Resources.information;
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(216, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Minecraft_Skin_Viewer_and_Stealer.Properties.Resources.door_out;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // poweredByMCHeadsnetToolStripMenuItem
            // 
            this.poweredByMCHeadsnetToolStripMenuItem.Image = global::Minecraft_Skin_Viewer_and_Stealer.Properties.Resources.c5ef3347_4593_4f39_8bb1_2eaa40dd986e;
            this.poweredByMCHeadsnetToolStripMenuItem.Name = "poweredByMCHeadsnetToolStripMenuItem";
            this.poweredByMCHeadsnetToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.poweredByMCHeadsnetToolStripMenuItem.Text = "Powered by MC-Heads.net";
            this.poweredByMCHeadsnetToolStripMenuItem.Click += new System.EventHandler(this.poweredByMCHeadsnetToolStripMenuItem_Click);
            // 
            // useThisSkinToolStripMenuItem
            // 
            this.useThisSkinToolStripMenuItem.Name = "useThisSkinToolStripMenuItem";
            this.useThisSkinToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.useThisSkinToolStripMenuItem.Text = "Use this Skin";
            this.useThisSkinToolStripMenuItem.Click += new System.EventHandler(this.useThisSkinToolStripMenuItem_Click);
            // 
            // uA
            // 
            this.uA.Image = global::Minecraft_Skin_Viewer_and_Stealer.Properties.Resources.information;
            this.uA.Name = "uA";
            this.uA.Size = new System.Drawing.Size(124, 20);
            this.uA.Text = "Update Available";
            this.uA.Visible = false;
            this.uA.Click += new System.EventHandler(this.uA_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 350);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pBoxSkin);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minecraft Skin Viewer and Stealer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSkin)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pBoxSkin;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem useThisSkinToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem poweredByMCHeadsnetToolStripMenuItem;
        private SaveFileDialog dialog;
        private ToolStripMenuItem uA;
    }
}