using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Tvisebebi_Indeqsatori_3
{
    class Class4
    {
        private char simbolo_1;
        private char simbolo_2;
        private char simbolo_3;
        private char simbolo_4;
        private char simbolo_5;
        public char this[int indexi]
        {
            get
            {
                switch (indexi)
                {
                    case 0: return simbolo_1;
                    case 1: return simbolo_2;
                    case 2: return simbolo_3;
                    case 3: return simbolo_4;
                    case 4: return simbolo_5;
                    default: return ' ';
                }
            }
            set
            {
                switch (indexi)
                {
                    case 0: simbolo_1 = value; break;
                    case 1: simbolo_2 = value; break;
                    case 2: simbolo_3 = value; break;
                    case 3: simbolo_4 = value; break;
                    case 4: simbolo_5 = value; break;
                }
            }
        }
    }
}
