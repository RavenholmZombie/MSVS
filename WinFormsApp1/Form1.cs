using Minecraft_Skin_Viewer_and_Stealer.Properties;
using System.Diagnostics;
using System.Net;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForUpdates();
            try
            {
                if (!String.IsNullOrEmpty(Settings.Default.cachedUsername))
                {
                    pBoxSkin.ImageLocation = "https://mc-heads.net/body/" + Settings.Default.cachedUsername;
                    textBox1.Text = Settings.Default.cachedUsername;
                }
                else
                {
                    pBoxSkin.ImageLocation = "https://mc-heads.net/body/MHF_Steve";
                }
            }
            catch(Exception ex)
            {
                pBoxSkin.BackgroundImage = Resources.error;
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
            MessageBox.Show("A simple Windows app that uses MC-Heads' API to view and download Minecraft skins" + "\n\n" + "Version " + Application.ProductVersion + "\n" + "Coded by RavenholmZombie", "About Minecraft Skin Viewer and Stealer", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                string newestversion = sr.ReadToEnd();
                Settings.Default.newerVersion = newestversion;
                Settings.Default.Save();
                string currentversion = Application.ProductVersion;

                if (newestversion.Contains(currentversion))
                {
                    // Current Version
                    uA.Visible = false;
                }
                else
                {
                    // Newer Version
                    uA.Visible = true;
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void uA_Click(object sender, EventArgs e)
        {
            Opacity = 0;
            OpenURL("https://github.com/RavenholmZombie/MSVS/releases/tag/" + Settings.Default.newerVersion);
            Application.Exit();
        }
    }
}