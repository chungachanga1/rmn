using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    class Kvadrati : Figura
    {
        private int fartobi;

        public Kvadrati(int gverdi1) : base(gverdi1)
        {
            fartobi = gverdi1 * gverdi1;
        }
        public int Fartobis_gamotvla()
        {
            return fartobi;
        }
    }
}
