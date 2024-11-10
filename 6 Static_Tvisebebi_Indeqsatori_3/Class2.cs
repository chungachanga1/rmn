using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Tvisebebi_Indeqsatori_3
{
    class Class2
    {
        private int ricxvi_1;
        private string str_1;
        public Class2()
        {
            ricxvi_1 = 0;
        }
        public int tviseba_int
        {
            get
            {
                return ricxvi_1;
            }
            set
            {
                if (value >= 0) ricxvi_1 = value;
            }
        }
        public string tviseba_string
        {
            get
            {
                return str_1;
            }
            set
            {
                if (value == "ნიკა" || value == "ნინო") str_1 = value;
            }
        }
    }
}
