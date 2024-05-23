using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class bai3_1 : Form
    {
        public bai3_1()
        {
            InitializeComponent();
        }

        string[] Numbers = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín", "mười", "mười một", "mười hai", "mười ba", "mười bốn", "mười lăm", "mười sáu", "mười bảy", "mười tám", "mười chín" };

        private string hangTram(long txt)
        {
            string result_str = "";
            if (txt < 10)
            {
                result_str = Numbers[txt];
            }
            else
            {
                if (txt > 99 && txt < 1000)
                {
                    result_str = result_str + Numbers[txt / 100] + " trăm ";
                    txt = txt % 100;

                }
                if (txt < 10)
                {
                    if (txt > 0)
                        result_str += "lẻ " + Numbers[txt];
                }
                else
                {
                    if (txt > 19)
                    {
                        result_str = result_str + Numbers[txt / 10] + " mươi ";
                        txt = txt % 10;
                    }
                    if (txt > 0 && txt < 20)
                    {
                        result_str += Numbers[txt];
                    }
                }
            }
            return result_str;
        }
        private string hangTram2(long txt)
        {
            string result_str = "";
            if (txt > 0)
            {
                result_str += Numbers[txt / 100] + " trăm ";
                txt = txt % 100;
                if (txt > 0 && txt < 10)
                {
                    result_str += "lẻ " + Numbers[txt];
                }
                else
                {
                    if (txt > 19)
                    {
                        result_str = result_str + Numbers[txt / 10] + " mươi ";
                        txt = txt % 10;
                    }
                    if (txt > 0 && txt < 20)
                    {
                        result_str += Numbers[txt];
                    }
                }
            }
            return result_str;
        }

        private string hangNgan(long txt)
        {
            string result_str = "";
            if (txt > 999 && txt < 1000000)
            {
                result_str = hangTram(txt / 1000) + " nghìn " + hangTram2(txt % 1000);
            }
            else result_str = hangTram(txt);
            return result_str;
        }
        private string hangNgan2(long txt)
        {
            string result_str = "";
            if (txt > 999 && txt < 1000000)
            {
                result_str = hangTram2(txt / 1000) + " nghìn " + hangTram2(txt % 1000);
            }
            else result_str = hangTram2(txt);
            return result_str;
        }
        private string hangTrieu(long txt)
        {
            string result_str = "";
            if (txt > 999999 && txt < 1000000000)
            {
                result_str = hangTram(txt / 1000000) + " triệu " + hangNgan2(txt % 1000000);
            }
            else result_str = hangNgan(txt);
            return result_str;
        }
        private string hangTrieu2(long txt)
        {
            string result_str = "";
            if (txt > 999999 && txt < 1000000000)
            {
                result_str = hangTram2(txt / 1000000) + " triệu " + hangNgan2(txt % 1000000);
            }
            else result_str = hangNgan2(txt);
            return result_str;
        }
        private string hangTy(long txt)
        {
            string result_str = "";
            if (txt > 999999999 && txt < 1000000000000)
            {
                result_str = hangTram(txt / 1000000000) + " tỷ " + hangTrieu2(txt % 1000000000);
            }
            else result_str = hangTrieu(txt);
            return result_str;
        }
        private void read_Click(object sender, EventArgs e)
        {
            long txt;
            if (long.TryParse(inputtext.Text, out txt) == false || inputtext.Text.Length > 12 || long.Parse(inputtext.Text) < 0)
            {
                MessageBox.Show("Vui lòng nhập chính xác định dạng");
                inputtext.Clear();
                return;
            }
            long temp = long.Parse(inputtext.Text);
            resulttext.Text = hangTy(temp);

        }
        private void delete_Click(object sender, EventArgs e)
        {
            inputtext.Clear();
            resulttext.Clear();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
