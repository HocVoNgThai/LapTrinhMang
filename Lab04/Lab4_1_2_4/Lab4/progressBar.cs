using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class progressBar : Form
    {
        public progressBar()
        {
            InitializeComponent();
        }
        public void progress(object sender, DownloadProgressChangedEventArgs e)
        {
            PrgBar.Value = e.ProgressPercentage;
            Label_progress.Text = e.ProgressPercentage.ToString();
            if (e.ProgressPercentage >= 100)
                Form_Closing();
        }

        private void Form_Closing()
        {
            this.Close();
        }

    }
}
