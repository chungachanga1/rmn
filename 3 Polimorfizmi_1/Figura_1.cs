using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polimorfizmi_1
{
    class Figura_1
    {
        public int gverdi_1, gverdi_2, gverdi_3;
        public double radiusi;
        private int perim_kvad, perim_mart, perim_sam;
        private int fart_kvad, fart_mart;
        double fart_sam, wris_sigrdze, fart_wris;
        public Figura_1(int gverdi_1)
        {
            this.gverdi_1 = gverdi_1;
            perim_kvad = 4 * this.gverdi_1;
            fart_kvad = this.gverdi_1 * this.gverdi_1;
        }
        public Figura_1(int gverdi_1, int gverdi_2)
        {
            this.gverdi_1 = gverdi_1;
            this.gverdi_2 = gverdi_2;
            perim_mart = 2 * (this.gverdi_1 + this.gverdi_2);
            fart_mart = this.gverdi_1 * this.gverdi_2;
        }
        public Figura_1(int gverdi_1, int gverdi_2, int gverdi_3)
        {
            this.gverdi_1 = gverdi_1;
            this.gverdi_2 = gverdi_2;
            this.gverdi_3 = gverdi_3;
            perim_sam = this.gverdi_1 + this.gverdi_2 + this.gverdi_3;
            fart_sam = this.gverdi_1 * this.gverdi_3 / 2.0;
        }
        public Figura_1(double radiusi)
        {
            this.radiusi = radiusi;
            wris_sigrdze = 2 * Math.PI * this.radiusi;
            fart_wris = Math.PI * Math.Pow(this.radiusi, 2);
        }
        public void Gamotana_Kvad(Label lab_1)
        {
            lab_1.Text = "კვადრატის პერიმეტრი = " + perim_kvad.ToString() +
                         "    კვადრატის ფართობი = " + fart_kvad.ToString();
        }
        public void Gamotana_Mart(Label lab_1)
        {
            lab_1.Text = "მართკუთხედის პერიმეტრი = " + perim_mart.ToString() +
                         "    მართკუთხედი ფართობი = " + fart_mart.ToString();
        }
        public void Gamotana_Sam(Label lab_1)
        {
            lab_1.Text = "სამკუთხედის პერიმეტრი = " + perim_sam.ToString() +
                         "    სამკუთხედი ფართობი = " + fart_sam.ToString();
        }
        public void Gamotana_Wre(Label lab_1)
        {
            lab_1.Text = "წრის სიგრძე = " + wris_sigrdze.ToString() +
                         "    წრის ფართობი = " + fart_wris.ToString();
        }
    }
}
