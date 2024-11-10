using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Tvisebebi_Indeqsatori_3
{
    class Class3
    {
        private int ricxvi_1;
        private int ricxvi_2;
        private int ricxvi_3;
        private int ricxvi_4;
        private int ricxvi_5;
        public int this[int indexi]
        {
            get
            {
                switch (indexi)
                {
                    case 0: return ricxvi_1;
                    case 1: return ricxvi_2;
                    case 2: return ricxvi_3;
                    case 3: return ricxvi_4;
                    case 4: return ricxvi_5;
                    default: return 0;
                }
            }
            set
            {
                switch (indexi)
                {
                    case 0: ricxvi_1 = value; break;
                    case 1: ricxvi_2 = value; break;
                    case 2: ricxvi_3 = value; break;
                    case 3: ricxvi_4 = value; break;
                    case 4: ricxvi_5 = value; break;
                }
            }
        }
    }
}
