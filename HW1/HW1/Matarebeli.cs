using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HW1
{
    /*1. შექმენით მატარებლის კლასი, რომელიც შეიცავს პრივატულ ცვლადებს:
ვაგონების რაოდენობასა და მგზავრების რაოდენობას 1 ვაგონში; ღია ცვლადებს:
ბილეთების ფასს და გაყიდული ბილეთების რაოდენობას. შეიცავს ღია მეთოდებს:
პირველი მეთოდი პრივატულ და ღია ცვლადებს მნიშვნელობებს ანიჭებს; მეორე
მეთოდს გამოაქვს პრივატული და ღია ცვლადების მნიშვნელობები; მესამე
მეთოდი გამოთვლის და აბრუნებს ბილეთების გაყიდვით მიღებულ თანხას.
მთავარ პროგრამაში ნაგულისხმევი კონსტრუქტორის გამოყენებით შექმენით
შესაბამისი ობიექტი და გამოიძახეთ სამივე მეთოდი. მონაცემების შესატანად
გამოიყენეთ TextBox ვიზუალური ელემენტი, გამოსატანად კი Label ვიზუალურ
ელემენტი.*/

    class Matarebeli
    {
        private int vagonebis_raodenoba;
        private int vagonis_tevadoba;
        public double biletis_fasi;
        public int gayiduli_biletebis_raodenoba;
        public double shemosavali;
        public void Minicheba(int par_1, int par_2, double par_3, int par_4)
        {
            vagonebis_raodenoba = par_1;
            vagonis_tevadoba = par_2;
            biletis_fasi = par_3;
            gayiduli_biletebis_raodenoba = par_4;
        }

        public void Gamotana(Label lab_1, Label lab_2, Label lab_3, Label lab_4)
        {
            lab_1.Text = vagonebis_raodenoba.ToString();
            lab_2.Text = vagonis_tevadoba.ToString();
            lab_3.Text = biletis_fasi.ToString();
            lab_4.Text = gayiduli_biletebis_raodenoba.ToString();
        }

        public double Gamotvla()
        {
            shemosavali = biletis_fasi * gayiduli_biletebis_raodenoba;
            return shemosavali;
        }
    }
}
