using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class Indicator
    {
        int id;
        double value;
        public int Id => id;
        public double Value => value;
        public Indicator(int id, double value)
        {
            this.id = id;
            this.value = value;
        }
    }
}
