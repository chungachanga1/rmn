using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konstructori_This_Sivrce_3
{
    /* შექმენით სამკუთხედის კლასი, რომელიც შეიცავს ღია ცვლადებს: სამკუთხედის სამივე
     * გვერდის ზომებს; პრივატულ ცვლადებს: სამკუთხედის პერიმეტრსა და ფართობს; ღია
     * მეთოდებს: პირველი მეთოდია კონსტრუქტორი, რომელიც ღია და პრივატულ ცვლადებს
     * მნიშვნელობებს ანიჭებს; მეორე მეთოდს გამოაქვს პრივატული ცვლადების მნიშვნელობები.
     * მთავარ პროგრამაში კონსტრუქტორის გამოყენებით შექმენით ობიექტი და გამოიძახეთ მეორე
     * მეთოდი. მონაცემების შესატანად გამოიყენეთ TextBox ვიზუალური ელემენტი, მონაცემების
     * გამოსატანად კი - Label ვიზუალური ელემენტი.*/
    class Samkutxedi
    {
        public int gverdi_1, gverdi_2, gverdi_3;
        private int perimetri;
        double fartobi;
        public Samkutxedi(int gverdi_1, int gverdi_2, int gverdi_3)
        {
            this.gverdi_1 = gverdi_1;
            this.gverdi_2 = gverdi_2;
            this.gverdi_3 = gverdi_3;
            perimetri = this.gverdi_1 + this.gverdi_2 + this.gverdi_3;
            fartobi = this.gverdi_1 * this.gverdi_3 / 2.0;
        }
        public void Gamotana(Label lab_1)
        {
            lab_1.Text = "პერიმეტრი = " + perimetri.ToString() +
                         "\nფართობი = " + fartobi.ToString();
        }
    }
}
