using System;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.Runtime.InteropServices;
using System.IO;
//using System.IO.Compression;

namespace SignUpDemo
{
    public partial class Update : Form
    {
        string filename;

        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int dc, int rv);

        Thread thread;
        public Update()
        {
            InitializeComponent();
        }
        WebClient client;

        private void Update_Load(object sender, EventArgs e)
        {
            client = new WebClient();
            client.DownloadProgressChanged += client_DownloadProgressChanged;
            client.DownloadFileCompleted += client_DownloadFileCompleted;
        }

        void client_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Update Downloaded successfully!","Update",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Install();
            
        }

        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                double recieve = double.Parse(e.BytesReceived.ToString());
                double total = double.Parse(e.TotalBytesToReceive.ToString());
                double per = recieve / total * 100;
                lbl_per.Text = "Downloaded " + int.Parse(Math.Truncate(per).ToString()) + "%";
                prog_update.Value = int.Parse(Math.Truncate(per).ToString());
            }));
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            int de;
            if (InternetGetConnectedState(out de,0).ToString().ToUpper() == "TRUE")
            {
                btn_up.Enabled = false;
                btn_cancel.Enabled = true;
                lbl_up.Text = "Downloading Update...";
                string url = @"https://foxlearn.com/asp-net/could-not-load-file-or-assembly-netstandard-548.html";
                thread = new Thread(() =>
                {
                    Uri uri = new Uri(url);
                    filename = System.IO.Path.GetFileName(uri.AbsolutePath);
                    client.DownloadFileAsync(uri, Application.StartupPath + @"\Update\" + filename);
                });
                thread.Start();
            }
            else
            {
                MessageBox.Show("Please check your internet connection and try again.","Internet",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }   

        private void btn_pa_Click(object sender, EventArgs e)
        {
            //Thread.Sleep(1000);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            thread.Abort();
            btn_up.Enabled = true;
            System.IO.File.Delete(Application.StartupPath + @"\Update\" + filename);
        }

        void Install()
        {

            File.Delete(@"Update\update.zip");
            /*System.Diagnostics.Process.Start(@"..\update.bat");
            Application.Exit();*/
        }
    }
}
