using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class Expert
    {
        static Expert instance;
        int id;
        string name;
        public int Id => id;
        public string Name => name;
        Expert()
        {
            this.id = 0;
            this.name = "";
        }
        public Expert(int id, string name)
        {
            this.id = id;
            this.name = name;
            instance = this;
        }
        public static Expert getInstance()
        {
            if (instance == null)
                instance = new Expert();
            return instance;
        }
    }
}
