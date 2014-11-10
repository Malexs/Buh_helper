using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyLibr
{
    public class EngMoney:Money
    {
        string[,] thebestmassiveever = {
             {"","one ","two ","three ","four ","five ","six ","seven ","eight ","nine "},
             {"ten ","eleven ","twelve ","thirteen ","fourteen ","fifteen ","sixteen ","seventeen ","eighteen ","nineteen "},
             {"","","twenty ","thirty ","fourty ","fifty ","sixty ","seventy ","eighty ","ninety "},
             {"","one hundred ","two hundred ","three hundred ","four hundred ","five hundred ","six hundred ","seven hundred ","eight hundred ","nine hundred "},
                                       };
        

        public EngMoney(string number, string curr)
        {
            this.isFemale = false;
            this.currency = curr;
            this.numberLength = number.Length;
            if (this.numberLength > 9 && this.numberLength <= 12)
            {
                this.bil = number.Substring(0, this.numberLength - 9);
                this.mil = number.Substring(this.numberLength - 9, 3);
                this.thous = number.Substring(this.numberLength - 6, 3);
                this.unit = number.Substring(this.numberLength - 3, 3);
            }
            else
                if (this.numberLength <= 9 && this.numberLength > 6)
                {
                    this.bil = "";
                    this.mil = number.Substring(0, this.numberLength - 6);
                    this.thous = number.Substring(this.numberLength - 6, 3);
                    this.unit = number.Substring(this.numberLength - 3, 3);
                }
                else
                    if (this.numberLength <= 6 && this.numberLength > 3)
                    {
                        this.bil = this.mil = "";
                        this.thous = number.Substring(0, this.numberLength - 3);
                        this.unit = number.Substring(this.numberLength - 3, 3);
                    }
                    else
                        if (this.numberLength <= 3 && this.numberLength > 0)
                        {
                            this.bil = this.mil = this.thous = "";
                            this.unit = number;
                        }
                        else
                            if (this.numberLength > 12)
                            {
                                throw new UserExeption("Impossible to transfer. Your number is too long.");
                            }
                            else
                                if (this.numberLength == 0)
                                {
                                    throw new UserExeption("Impossible to transfer. Empty string.");
                                }
        }

        //Метод преобразования числового значения в слова
        string IntToStrTranfer(string somestring, bool isFemale) //true - female, false - male
        {
            string result = "";
            //((int)somestring[]-48); Не забывать про 48 (ASCII),иначе вылет за пределы массива!!!
            switch (somestring.Length)
            {
                case 3:
                    {
                        if (somestring[1].Equals('1')) result += thebestmassiveever[3, (int)(somestring[0]) - 48] + thebestmassiveever[1, (int)(somestring[2]) - 48];
                            else
                                 result += thebestmassiveever[3, (int)somestring[0] - 48] + thebestmassiveever[2, (int)(somestring[1]) - 48] + thebestmassiveever[0, (int)(somestring[2]) - 48]; 
                        break;
                    }
                case 2:
                    {
                        if (somestring[0].Equals('1')) result += thebestmassiveever[1, (int)(somestring[1]) - 48];
                        else
                            result += thebestmassiveever[2, (int)(somestring[0]) - 48] + thebestmassiveever[0, (int)(somestring[1]) - 48];
                        break;
                    }
                case 1:
                    {
                        result += thebestmassiveever[0, (int)(somestring[0]) - 48];
                        break;
                    }
                default:
                    break;
            }
            return result;
        }

        //Метод генерирования верного окончания для получаемого разряда
        protected override string AmountAnalize (string somestring, string amount)
        {
           string result = "";
           if (!somestring.Equals("") && !somestring.Equals("0") && !somestring.Equals("00") && !somestring.Equals("000"))
           {
                   AmountChooseEng ac = new AmountChooseEng(amount);
                   result = ac.ReturnVal();              
           }
           return result;
        }

        //Метод генерирования окончания строки в зависимости от выбранной валюты
        protected override string CurrencyAnalize(string unit, string currency)
        {
            string result = "";
            int last = 0;
            if (!unit.Equals(""))
            {
                if (!(unit.Length > 1 && (int)(unit[unit.Length - 2] - 48) == 1))   //Иначе оставляем Last = 0
                    last = (int)(unit[unit.Length - 1]) - 48; 
                CurrChooseEng cc = new CurrChooseEng(currency, last);
                result = cc.ReturnVal();
            }
            return result;
        }

        //Метод для связи с классом
        public override string Calculate()
        {
            StringBuilder sb = new StringBuilder();
            //sb.Append(this.bil + " " + this.mil + " " + this.thous + " " + this.unit);
            sb.Append(IntToStrTranfer(bil, false) + AmountAnalize(bil,"bil"));
            sb.Append(IntToStrTranfer(mil, false) + AmountAnalize(mil,"mil"));
            sb.Append(IntToStrTranfer(thous, true) + AmountAnalize(thous,"thous"));
            sb.Append(IntToStrTranfer(unit, false) + CurrencyAnalize(unit,currency));
            return sb.ToString();
        }


    }
}
