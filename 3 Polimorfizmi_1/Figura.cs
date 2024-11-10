using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizmi_1
{
    class Figura
    {
        public int Perimetri(int gverdi_1)
        {
            return gverdi_1 * 4;
        }
        public int Perimetri(int gverdi_1, int gverdi_2)
        {
            return 2 * (gverdi_1 + gverdi_2);
        }
        public double Perimetri(double radiusi)
        {
            return 2 * 3.14 * radiusi;
        }
        public int Perimetri(int gverdi_1, int gverdi_2, int gverdi_3)
        {
            return gverdi_1 + gverdi_2 + gverdi_3;
        }
    }
}
