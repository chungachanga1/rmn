using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    class Samkutxedi : Figura
    {
        private int perimetri;

        public Samkutxedi(int gverdi1, int gverdi2, int gverdi3) : base(gverdi1, gverdi2, gverdi3)
        {
            perimetri = gverdi1 + gverdi2 + gverdi3;
        }

        public int Perimeteris_gamotvla()
        {
            return perimetri;
        }
    }
}
