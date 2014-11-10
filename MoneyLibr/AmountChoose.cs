using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyLibr
{
    public class AmountChoose:Choose
    {
            string[,] strmas = {
            {"тысяча ","миллион ","миллиард "},
            {"тысячи ","миллиона ","миллиарда "},
            {"тысяч ","миллионов ","миллиардов "},
                           };

        public AmountChoose(string smth, int last)
        {
            if (last == 1) this.last = 0;
                else if (last > 1 && last < 5) this.last = 1;
                        else this.last = 2;
            if (smth.Equals("thous")) this.unit = 0;
                else if (smth.Equals("mil")) this.unit = 1;
                        else this.unit = 2;
        }

        public AmountChoose(string smth)
        {
            if (smth.Equals("thous")) this.unit = 0;
                else if (smth.Equals("mil")) this.unit = 1;
                        else this.unit = 2;
            this.last = 2;
        }

    public override string ReturnVal()
        {
            string result = strmas[last, unit];
            return result;
        }
    }
}
