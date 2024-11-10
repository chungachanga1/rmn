using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memkvidreobitoba_1
{
    class Kvadrati
    {
        public int gverdi_1;
        protected int perimetri;
        private int fartobi;
        public Kvadrati(int gverdi_1)
        {
            this.gverdi_1 = gverdi_1;
        }
        public int Perimetri_Kvadrati()
        {
            perimetri = gverdi_1 * 4;
            return perimetri;
            //???return gverdi_1 * 4;
        }
        public int Fartobi_Kvadrati()
        {
            fartobi = gverdi_1 * gverdi_1;
            return fartobi;
        }
    }
    class Martkutxedi : Kvadrati
    {
        public int gverdi_2;
        private int fartobi;
        public Martkutxedi(int gverdi_1, int gverdi_2) : base(gverdi_1) 
        {
            this.gverdi_2 = gverdi_2;
        }
        public int Perimetri_Martkutxedi()
        {
            perimetri = (gverdi_1 + gverdi_2) * 2;
            return perimetri;
        }
        public int Fartobi_Martkutxedi()
        {
            fartobi = gverdi_1 * gverdi_2;
            return fartobi;
        }
    }
    class Samkutxedi : Martkutxedi
    {
        public int gverdi_3;
        private double fartobi;
        public Samkutxedi(int gverdi_1, int gverdi_2, int gverdi_3) : base(gverdi_1, gverdi_2)
        {
            this.gverdi_3 = gverdi_3;
        }
        public int Perimetri_Samkutxedi()
        {
            perimetri = gverdi_1 + gverdi_2 + gverdi_3;
            return perimetri;
        }
        public double Fartobi_Samkutxedi()
        {
            fartobi = gverdi_1 * gverdi_3 / 2.0;
            return fartobi;
        }
    }
}
