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

namespace btvn_bai2
{
    public partial class Form2 : Form
    {
        public string SubItemValue { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Hiển thị giá trị subitem
            label1.Text = SubItemValue;
        }
    }
}
