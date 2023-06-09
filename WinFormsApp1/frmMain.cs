using Minecraft_Skin_Viewer_and_Stealer;
using Minecraft_Skin_Viewer_and_Stealer.Properties;
using System.Diagnostics;
using System.Net;

namespace WinFormsApp1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioSkin.Checked = true;
            if (CheckForInternetConnection(10000, "https://google.com"))
            {
                CheckForUpdates(Application.ProductVersion);

                toolTip.SetToolTip(radioSkin, "Download the player's raw skin file.");
                toolTip.SetToolTip(radioIso, "Download an isometric render of the player's skin.");
                toolTip.SetToolTip(radioFace, "Download a flat face render of the player's skin.");
                toolTip.SetToolTip(radioHead, "Download an isometric render of the player's head.");

                try
                {
                    if (!String.IsNullOrEmpty(Settings.Default.cachedUsername))
                    {
                        pBoxSkin.ImageLocation = "https://mc-heads.net/body/" + Settings.Default.cachedUsername;
                        textboxUsername.Text = Settings.Default.cachedUsername;
                        showInfoAboutUSERToolStripMenuItem.Text = "Show info about " + Settings.Default.cachedUsername;
                        showInfoAboutUSERToolStripMenuItem.Visible = true;
                        PopulateIcon();
                    }
                    else
                    {
                        pBoxSkin.ImageLocation = "https://mc-heads.net/body/MHF_Steve";
                        showInfoAboutUSERToolStripMenuItem.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    pBoxSkin.BackgroundImage = Resources.error;
                }
            }
            else
            {
                Opacity = 0;
                if (MessageBox.Show("An active Internet connection is required to use this app. Please check your network and try again.", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void darkTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textboxUsername.Text))
            {
                btnShow.Enabled = true;
                btnDownload.Enabled = true;
            }
            else
            {
                btnShow.Enabled = false;
                btnDownload.Enabled = false;
            }
        }
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAbout ab = new frmAbout();
            ab.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void poweredByMCHeadsnetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenURL("https://mc-heads.net");
        }

        private void useThisSkinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("After saving this skin to your PC, you will be taken to Minecraft's website. \n\n After logging into your Minecraft account, you will be able to upload the skin to your profile.", "Use this player's skin", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    btnDownload.PerformClick();
                    OpenURL("https://mc-heads.net/change/" + textboxUsername.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to complete operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CheckForUpdates(string currentVersion)
        {
            try
            {
                WebClient wC = new WebClient();

                if (!wC.DownloadString("https://raw.githubusercontent.com/RavenholmZombie/MSVS/main/update.txt").Contains(currentVersion))
                {
                    // Newer Version
                    updateAvailableToolStripMenuItem.Visible = true;
                }
                else
                {
                    // Up to date already
                    updateAvailableToolStripMenuItem.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while checking for updates: \n" + ex.Message, "Unable to check for updates", MessageBoxButtons.OK, MessageBoxIcon.Error);
                updateAvailableToolStripMenuItem.Visible = false;
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

        private void uA_Click(object sender, EventArgs e)
        {
            frmAbout frmA = new frmAbout();
            frmA.tabControl1.SelectedIndex = 3;
            frmA.btnCheck.PerformClick();
            frmA.ShowDialog();
        }

        private void showPlayerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenURL("https://namemc.com/profile/" + Settings.Default.cachedUsername);
        }

        public void PopulateIcon()
        {
            try
            {
                WebClient wc = new WebClient();
                byte[] originalData = wc.DownloadData("https://mc-heads.net/head/" + textboxUsername.Text);

                MemoryStream stream = new MemoryStream(originalData);
                Bitmap icn_png = new Bitmap(stream);

                IntPtr HIcn = icn_png.GetHicon();
                Icon icn = Icon.FromHandle(HIcn);
                Icon = icn;
            }
            catch (Exception ex)
            {

            }
        }

        public static bool CheckForInternetConnection(int timeoutMs = 10000, string url = null)
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.KeepAlive = false;
                request.Timeout = timeoutMs;
                using (var response = (HttpWebResponse)request.GetResponse())
                    return true;
            }
            catch
            {
                return false;
            }
        }

        private void radioSkin_CheckedChanged(object sender, EventArgs e)
        {
            btnDownload.Text = "Download Skin";
        }

        private void radioIso_CheckedChanged(object sender, EventArgs e)
        {
            btnDownload.Text = "Download Isometric Render";
        }

        private void radioFace_CheckedChanged(object sender, EventArgs e)
        {
            btnDownload.Text = "Download Face";
        }

        private void radioHead_CheckedChanged(object sender, EventArgs e)
        {
            btnDownload.Text = "Download Head";
        }

        private void darkButton1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textboxUsername.Text))
            {
                try
                {
                    btnShow.PerformClick();
                    dialog.Title = "Choose where to save your file";
                    dialog.Filter = "PNG Images (*.png)|*.png";
                    dialog.FileName = textboxUsername.Text;

                    var result = dialog.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        var wClient = new WebClient();

                        if (radioSkin.Checked)
                        {
                            wClient.DownloadFileAsync(new Uri("https://mc-heads.net/skin/" + textboxUsername.Text), dialog.FileName);
                        }
                        if (radioIso.Checked)
                        {
                            wClient.DownloadFileAsync(new Uri("https://mc-heads.net/body/" + textboxUsername.Text), dialog.FileName);
                        }
                        if (radioFace.Checked)
                        {
                            wClient.DownloadFileAsync(new Uri("https://mc-heads.net/avatar/" + textboxUsername.Text), dialog.FileName);
                        }
                        if (radioHead.Checked)
                        {
                            wClient.DownloadFileAsync(new Uri("https://mc-heads.net/head/" + textboxUsername.Text), dialog.FileName);
                        }

                        if (File.Exists(dialog.FileName))
                        {
                            Process.Start(new ProcessStartInfo("explorer.exe", " /select, " + dialog.FileName));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Unable to complete operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void darkButton2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textboxUsername.Text))
            {
                try
                {
                    pBoxSkin.ImageLocation = "https://mc-heads.net/body/" + textboxUsername.Text;
                    Settings.Default.cachedUsername = textboxUsername.Text;
                    Settings.Default.Save();
                    showInfoAboutUSERToolStripMenuItem.Text = "Show info about " + textboxUsername.Text;
                    showInfoAboutUSERToolStripMenuItem.Visible = true;
                    PopulateIcon();

                }
                catch (Exception ex)
                {
                    pBoxSkin.BackgroundImage = Resources.error;
                    pBoxSkin.ImageLocation = null;
                    MessageBox.Show(ex.Message, "Unable to complete operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void useThisSkinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("After saving this skin to your PC, you will be taken to Minecraft's website. \n\n After logging into your Minecraft/Microsoft account, you will be able to upload the skin to your profile.", "Use this player's skin", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    btnDownload.PerformClick();
                    OpenURL("https://mc-heads.net/change/" + textboxUsername.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to complete operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateAvailableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frmA = new frmAbout();
            frmA.tabControl1.SelectedIndex = 3;
            frmA.btnCheck.PerformClick();
            frmA.ShowDialog();
        }

        private void aboutToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmAbout ab = new frmAbout();
            ab.ShowDialog();
        }

        private void showInfoAboutUSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenURL("https://namemc.com/profile/" + Settings.Default.cachedUsername);
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void poweredByMCHeadsnetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenURL("https://mc-heads.net");
        }

        private void radioSkin_CheckedChanged_1(object sender, EventArgs e)
        {
            btnDownload.Text = "Download Skin";
        }

        private void radioIso_CheckedChanged_1(object sender, EventArgs e)
        {
            btnDownload.Text = "Download Isometric Model";
        }

        private void radioFace_CheckedChanged_1(object sender, EventArgs e)
        {
            btnDownload.Text = "Download Face";
        }

        private void radioHead_CheckedChanged_1(object sender, EventArgs e)
        {
            btnDownload.Text = "Download Head";
        }

        private void textboxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnShow.PerformClick();
            }
        }
    }
}