﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyLibr
{
    public class CurrChooseEng:Choose
    {
                   string[,] strmas = {
            {"ruble ","dollar ","euro "},
            {"rubles ","dollars ","euros "}
                           };

    public CurrChooseEng(string smth, int last)
        {
            if (last == 1) this.last = 0;
                        else this.last = 1;
            if (smth.Equals("rub")) this.unit = 0;
                else if (smth.Equals("dol")) this.unit = 1;
                        else this.unit = 2;
        }

        
    public override string ReturnVal()
        {
            string result = strmas[last, unit];
            return result;
        }

    }
}
