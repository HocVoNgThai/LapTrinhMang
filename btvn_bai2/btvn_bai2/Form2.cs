using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace btvn_bai2
{
    public partial class Form2 : Form
    {
        string html;
        public Form2(string body)
        {
            InitializeComponent();
            html = body;
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Hiển thị giá trị subitem


        }

        private void button1_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.NavigateToString(html);
        }
    }
}
