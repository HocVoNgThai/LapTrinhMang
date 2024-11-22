using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_6
{
    public partial class formEmail : Form
    {
        public formEmail(string from, string dest, string subject,string html)
        {
            InitializeComponent();
            webBrowser1.DocumentText = html;
            this.Text = subject;
            lbDest.Text = $"To: {dest}";
            lbFrom.Text = $"From: {from}";
            lbSubject.Text = $"Subject: {subject}";

        }
    }
}
