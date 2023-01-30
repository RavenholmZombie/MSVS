using Minecraft_Skin_Viewer_and_Stealer;
using Minecraft_Skin_Viewer_and_Stealer.Properties;
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;

namespace WinFormsApp1
{
    public partial class frmMain : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(CheckForInternetConnection(10000, "http://www.gstatic.com/generate_204"))
            {
                CheckForUpdates();
                try
                {
                    if (!String.IsNullOrEmpty(Settings.Default.cachedUsername))
                    {
                        pBoxSkin.ImageLocation = "https://mc-heads.net/body/" + Settings.Default.cachedUsername;
                        textBox1.Text = Settings.Default.cachedUsername;
                        showPlayerInfoToolStripMenuItem.Text = "Show info about " + Settings.Default.cachedUsername;
                        showPlayerInfoToolStripMenuItem.Visible = true;
                        PopulateIcon();
                    }
                    else
                    {
                        pBoxSkin.ImageLocation = "https://mc-heads.net/body/MHF_Steve";
                        showPlayerInfoToolStripMenuItem.Visible = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(textBox1.Text))
            {
                try
                {
                    pBoxSkin.ImageLocation = "https://mc-heads.net/body/" + textBox1.Text;
                    Settings.Default.cachedUsername = textBox1.Text;
                    Settings.Default.Save();
                    showPlayerInfoToolStripMenuItem.Text = "Show info about " + textBox1.Text;
                    showPlayerInfoToolStripMenuItem.Visible = true;
                    PopulateIcon();

                }
                catch(Exception ex)
                {
                    pBoxSkin.BackgroundImage = Resources.error;
                    pBoxSkin.ImageLocation = null;
                    MessageBox.Show(ex.Message, "Unable to complete operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(textBox1.Text))
            {
                try
                {
                    button1.PerformClick();
                    dialog.Filter = "PNG Images (*.png)|*.png";
                    dialog.Title = "Choose where to save " + textBox1.Text + "'s skin";
                    dialog.FileName = textBox1.Text;

                    var result = dialog.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        var wClient = new WebClient();
                        var skinURI = new Uri("https://mc-heads.net/skin/" + textBox1.Text);
                        wClient.DownloadFileAsync(skinURI, dialog.FileName);
                        


                        if (File.Exists(dialog.FileName))
                        {
                            Process.Start(new ProcessStartInfo("explorer.exe", " /select, " + dialog.FileName));
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Unable to complete operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(textBox1.Text))
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
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
                if(MessageBox.Show("After saving this skin to your PC, you will be taken to Minecraft's website. \n\n After logging into your Minecraft account, you will be able to upload the skin to your profile.", "Use this player's skin", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    button2.PerformClick();
                    OpenURL("https://mc-heads.net/change/" + textBox1.Text);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to complete operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CheckForUpdates()
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://raw.githubusercontent.com/RavenholmZombie/MSVS/main/update.txt");
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                StreamReader sr = new StreamReader(response.GetResponseStream());
                string newestVersion = sr.ReadToEnd();
                string currentVersion = Application.ProductVersion;

                if (newestVersion != currentVersion)
                {
                    uA.Visible = true;
                }
                else
                {
                    uA.Visible = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occured while checking for updates: \n" + ex.Message, "Unable to check for updates", MessageBoxButtons.OK, MessageBoxIcon.Error);
                uA.Visible = false;
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
            catch(Exception ex)
            {
                MessageBox.Show("Unable to process URL request: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uA_Click(object sender, EventArgs e)
        {
            Opacity = 0;
            OpenURL("https://github.com/RavenholmZombie/MSVS/releases/tag/" + Settings.Default.newerVersion);
            Application.Exit();
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
                byte[] originalData = wc.DownloadData("https://mc-heads.net/head/" + textBox1.Text);

                MemoryStream stream = new MemoryStream(originalData);
                Bitmap icn_png = new Bitmap(stream);

                IntPtr HIcn = icn_png.GetHicon();
                Icon icn = Icon.FromHandle(HIcn);
                Icon = icn;
            }
            catch(Exception ex)
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
    }
}