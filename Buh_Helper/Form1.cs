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
        string currchoose = "rub";    //Значения выбора
        bool isrussian = true;        //по умолчанию.
        Regex rgx = new Regex("[^0-9]");

        public MainForm()
        {
            InitializeComponent();
        }

        //Убрать ненужные нули в начале строки
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

        //Запуск процесса перевода
        private void StartButton_Click(object sender, EventArgs e)
        {
            string str1 = EnterTextBox.Text;
            str1 = rgx.Replace(str1, "");
            try
            {
                str1 = KillNulls(str1);
                PrevNumb.Text = str1;
                if (isrussian)
                {
                    RusMoney test = new RusMoney(str1, currchoose);
                    EnterTextBox.Clear();
                    ResultBox.Text = test.Calculate();
                }
                else
                {
                    EngMoney test = new EngMoney(str1, currchoose);
                    EnterTextBox.Clear();
                    ResultBox.Text = test.Calculate();
                }
            }
            catch (UserExeption ex)
            {
                EnterTextBox.Clear();
                PrevNumb.Clear();
                ResultBox.Text = ""+ex;
            }
            catch
            {
                EnterTextBox.Clear();
                PrevNumb.Clear();
                ResultBox.Text = "Ошибка!";
            }
        }

        //Выбор валюты - рубли (по умолчанию)
        private void RUBradioButton_CheckedChanged(object sender, EventArgs e)
        {
            currchoose = "rub";
        }

        //Выбор валюты - доллар
        private void DollarsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            currchoose = "dol";
        }

        //Выбор валюты - евро
        private void EuroRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            currchoose = "eur";
        }

        //Выбор языка результата - русский (по умолчанию)
        private void RUradioButton_CheckedChanged(object sender, EventArgs e)
        {
            isrussian = true;
        }

        //Выбор языка результата - английский
        private void ENGradioButton_CheckedChanged(object sender, EventArgs e)
        {
            isrussian = false;
        }

        //Вернуть предыдущее значение в начальную строку
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            EnterTextBox.Text = PrevNumb.Text;
            PrevNumb.Clear();
            ResultBox.Clear();
        }

        //Заносим результат в буфер обмена
        private void Copy_Button_Click(object sender, EventArgs e)
        {
            if (!ResultBox.Text.Equals(""))
                Clipboard.SetText(ResultBox.Text);
        }

        //Заносим содержимое буфера обмена
        private void Paste_Button_Click(object sender, EventArgs e)
        {
            EnterTextBox.Text = Clipboard.GetText();
            EnterTextBox.Text = rgx.Replace(EnterTextBox.Text,"");
        }

    }
}
//12               0rge0903