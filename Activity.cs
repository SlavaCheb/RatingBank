using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class Activity
    {
        Bank bank;
        Indicator indicator;
        double value;
        public Bank Bank => bank;
        public Indicator Indicator => indicator;
        public double Value => value;
        public Activity(Bank b, Indicator i, double v)
        {
            bank = Bank;
            indicator = i;
            value = v;
        }
    }
}
