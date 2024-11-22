using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Policy;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Sockets;

namespace Lab4
{
    public partial class Bai02 : Form
    {
        WebClient myClient;
        Stream replied;
        public Bai02()
        {
            InitializeComponent();

            //this.myClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCallback4);

            /*this.myClient.DownloadFileCompleted += (sender, e) =>
            {
                // Kiểm tra xem quá trình tải xuống có thành công hay không
                if (e.Error == null)
                {
                    Tbx_Progress.Text = "Download Completed";
                }
                else
                {
                    Tbx_Progress.Text = "Error";
                    return;
                }

            };
            */
        }
        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                PrgBar.Value = e.ProgressPercentage;
                Label_Progress.Text = e.ProgressPercentage.ToString() + "%";
            }));
        }

        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate {
                myClient.CancelAsync();
                if (!File.Exists(Tbx_fileUrl.Text)) { MessageBox.Show("Lỗi vị trí lưu file!"); return; }
                using (FileStream fs = new FileStream(Tbx_fileUrl.Text, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string data = sr.ReadToEnd();
                        Rtbx_Content.Text = data;
                    }
                }
                Btn_Get.Enabled = true;
                replied.Close();
                myClient.Dispose();
            });

        }

        private void Btn_Get_Click(object sender, EventArgs e)
        {
            PrgBar.Value = 0;
            Label_Progress.Text = String.Empty;
            /*Stream Response = myClient.OpenRead(Tbx_Url.Text);
            myClient.DownloadFileAsync(new Uri(Tbx_Url.Text), Tbx_fileUrl.Text);*/
            if(Tbx_Url.Text == String.Empty || Tbx_fileUrl.Text== String.Empty) 
            {
                MessageBox.Show("Chưa nhập URL hoặc filePath!");
                return;
            }

            Btn_Get.Enabled = false;

            try
            {
          
                    myClient = new WebClient();
                    Uri uri = new Uri(Tbx_Url.Text);
                    replied = myClient.OpenRead(uri);

                    myClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                    myClient.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                    myClient.DownloadFileAsync(uri, Tbx_fileUrl.Text);
                    

                
                //MessageBox.Show("Successfully Downloaded!");
            }
            catch
            {
                MessageBox.Show("Không thành công!");
            }

            
            return;
        }
}
}
    