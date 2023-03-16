using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    public class Criteria
    {
        int id;
        string name;
        double weight;
        int indicator1;
        int indicator2;
        public int Id => id;
        public string Name => name;
        public double Weight => weight;
        public int Indicator1 => indicator1;
        public int Indicator2 => indicator2;
        public Criteria(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public Criteria(int id, double weight, int i1, int i2)
        {
            this.id = id;
            this.weight = weight;
            indicator1 = i1;
            indicator2 = i2;
        }
    }
}
