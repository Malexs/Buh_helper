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
using MoneyLibr;
using System.Text.RegularExpressions;

namespace Buh_Helper
{
    public partial class MainForm : Form
    {
        string currchoose = "rub";

        public MainForm()
        {
            InitializeComponent();
        }

        string KillNulls(string killerstring)
        {
            string result = "";
            if (!killerstring.Equals(""))
            {
                if ((int)(killerstring[0] - 48) == 0)
                {
                    while (!killerstring.Equals("") && (int)(killerstring[0] - 48) == 0)
                        killerstring = killerstring.Substring(1);
                }
            }
            result = killerstring;
            return result;
        }


        private void StartButton_Click(object sender, EventArgs e)
        {
            Regex rgx = new Regex("[^0-9]");
            string str1 = EnterTextBox.Text;
            str1 = rgx.Replace(str1, "");
            try
            {
                str1 = KillNulls(str1);
                PrevNumb.Text = str1;
                MoneyClass test = new MoneyClass(str1,currchoose);
                EnterTextBox.Clear();
                ResultBox.Text = test.Calculate();
            }
            catch (MoneyExeption ex)
            {
                ResultBox.Text = ""+ex;
            }
            catch
            {
                ResultBox.Text = "Ошибка!";
            }
        }

        private void RUBradioButton_CheckedChanged(object sender, EventArgs e)
        {
            currchoose = "rub";
        }

        private void DollarsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            currchoose = "dol";
        }

        private void EuroRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            currchoose = "eur";
        }


    }
}
