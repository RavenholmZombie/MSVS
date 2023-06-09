using Minecraft_Skin_Viewer_and_Stealer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Minecraft_Skin_Viewer_and_Stealer
{
    public partial class frmAbout : Form
    {
        private string newVersionFromGitHub;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }
        public frmAbout()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            lblVersion.Text = "Version " + Application.ProductVersion;
            lblCurrentVersion.Text = "Your version: " + Application.ProductVersion;
            CheckForUpdates(Application.ProductVersion);
            progressBar1.Visible = false;
            label3.Visible = false;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            CheckForUpdates(Application.ProductVersion);
        }

        public void CheckForUpdates(string currentVersion)
        {
            try
            {
                WebClient wC = new WebClient();

                if (!wC.DownloadString("https://raw.githubusercontent.com/RavenholmZombie/MSVS/main/update.txt").Contains(currentVersion))
                {
                    // Newer Version
                    lblNewerVersion.Text = "Newer version: " + wC.DownloadString("https://raw.githubusercontent.com/RavenholmZombie/MSVS/main/update.txt");
                    btnDownload.Enabled = true;
                    newVersionFromGitHub = wC.DownloadString("https://raw.githubusercontent.com/RavenholmZombie/MSVS/main/update.txt");
                }
                else
                {
                    // Up to date already
                    lblNewerVersion.Text = "You are up to date";
                    btnDownload.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while checking for updates: \n" + ex.Message, "Unable to check for updates", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                sfd.Filter = "Executables (*.exe)|*.exe";
                sfd.Title = "Choose where to save the updater file";
                sfd.FileName = "Install Minecraft Skin Viewer and Stealer";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (WebClient wc = new WebClient())
                    {
                        wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                        wc.DownloadFileCompleted += wc_DownloadFileCompleted;
                        progressBar1.Visible = true;
                        label3.Visible = true;
                        wc.DownloadFileAsync(
                            new Uri("https://github.com/RavenholmZombie/MSVS/releases/latest/download/Install.Minecraft.Skin.Viewer.and.Stealer.exe"),
                            sfd.FileName
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to download update \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        void wc_DownloadFileCompleted(object? sender, AsyncCompletedEventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Visible = false;
            label3.Visible = false;
            if (MessageBox.Show("Update downloaded. Ready to install?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (File.Exists(sfd.FileName))
                {
                    Process.Start(new ProcessStartInfo("explorer.exe", " /run, " + sfd.FileName));
                    Application.Exit();
                }
            }
        }

        public void OpenURL(String urlIn)
        {
            try
            {
                var ps = new ProcessStartInfo(urlIn)
                {
                    UseShellExecute = true,
                    Verb = "open"
                };
                Process.Start(ps);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to process URL request: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
