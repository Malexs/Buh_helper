using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyLibr
{
    public class AmountChooseEng:Choose
    {
                    string[] strmas =new string[] {"thousand ","million ","billion "};

        public AmountChooseEng(string smth)
        {
            if (smth.Equals("thous")) this.unit = 0;
                else if (smth.Equals("mil")) this.unit = 1;
                        else this.unit = 2;
        }

    public override string ReturnVal()
        {
            string result = strmas[unit];
            return result;
        }

    }
}
