using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyLibr
{
    


    public class RusMoney:Money
    {
        
        string[,] thebestmassiveever = {
             {"","один ","два ","три ","четыре ","пять ","шесть ","семь ","восемь ","девять "},
             {"десять ","одиннадцать ","двенадцать ","тринадцать ","четырнадцать ","пятнадцать ","шестнадцать ","семнадцать ","восемнадцать ","девятнадцать "},
             {"","","двадцать ","тридцать ","сорок ","пятьдесят ","шестьдесят ","семьдесят ","восемьдесят ","девяносто "},
             {"","сто ","двести ","триста ","четыреста ","пятьсот ","шестьсот ","семьсот ","восемьсот ","девятьсот "},
                                       };
        

        public RusMoney(string number, string curr)
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
                                throw new UserExeption("Невозможно перевести. Слишком большое число!");
                            }
                            else
                                if (this.numberLength == 0)
                                {
                                    throw new UserExeption("Невозможно перевести. Пустая строка!");
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
                                if (isFemale && somestring[2].Equals('1'))
                                {
                                    result += thebestmassiveever[3, (int)somestring[0] - 48] + thebestmassiveever[2, (int)(somestring[1]) - 48] + "одна ";
                                }
                                else
                                    if (isFemale && somestring[2].Equals('2'))
                                    {
                                        result += thebestmassiveever[3, (int)somestring[0] - 48] + thebestmassiveever[2, (int)(somestring[1]) - 48] + "две ";
                                    }
                                    else result += thebestmassiveever[3, (int)somestring[0] - 48] + thebestmassiveever[2, (int)(somestring[1]) - 48] + thebestmassiveever[0, (int)(somestring[2]) - 48]; 
                        break;
                    }
                case 2:
                    {
                        if (somestring[0].Equals('1')) result += thebestmassiveever[1, (int)(somestring[1]) - 48];
                        else
                            if (isFemale && somestring[1].Equals('1'))
                            {
                                result += thebestmassiveever[2, (int)(somestring[0]) - 48] + "одна ";
                            }
                            else
                                if (isFemale && somestring[1].Equals('2'))
                                {
                                    result += thebestmassiveever[2, (int)(somestring[0]) - 48] + "две ";
                                }
                                else result += thebestmassiveever[2, (int)(somestring[0]) - 48] + thebestmassiveever[0, (int)(somestring[1]) - 48];
                        break;
                    }
                case 1:
                    {
                        if (isFemale && somestring[0].Equals('1'))
                            {
                                result += "одна ";
                            }
                            else
                                if (isFemale && somestring[0].Equals('2'))
                                {
                                    result += "две ";
                                }
                                else result += thebestmassiveever[0, (int)(somestring[0]) - 48];
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
               if (somestring.Length > 1 && somestring[(somestring.Length - 2)].Equals('1'))
               {
                   AmountChoose ac = new AmountChoose(amount);
                   result = ac.ReturnVal();
                   
               }
               else
               {
                   int last = (int)somestring[somestring.Length - 1] - 48;                   
                   AmountChoose ac = new AmountChoose(amount, last);
                   result = ac.ReturnVal();
               }
              
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
                CurrencyChoose cc = new CurrencyChoose(currency, last);
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
 