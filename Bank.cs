using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class Bank
    {
        int rk;
        string name;
        public int Rk => rk;
        public string Name => name;
        public Bank(int rk, string name)
        {
            this.rk = rk;
            this.name = name;
        }
    }
}
