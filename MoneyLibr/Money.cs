using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyLibr
{
    public abstract class Money
    {
        protected string bil, mil, thous, unit;
        protected int numberLength;
        protected string currency;
        protected bool isFemale;
        protected abstract string AmountAnalize(string somestring, string amount);
        protected abstract string CurrencyAnalize(string unit, string currency);
        public abstract string Calculate();
    }
}
