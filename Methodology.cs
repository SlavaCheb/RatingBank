using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class Methodology
    {
        int id;
        List<Criteria> criterias;
        public int Id => id;
        public List<Criteria> Criterias => criterias;
        public Methodology(int id, List<Criteria> criterias)
        {
            this.id = id;
            this.criterias = criterias;
        }
    }
}
