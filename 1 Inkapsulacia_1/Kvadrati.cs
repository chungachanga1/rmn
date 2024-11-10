using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inkapsulacia_1
{
    /*შექმენით კვადრატის კლასი, რომელიც შეიცავს ღია ცვლადს: კვადრატის გვერდის 
     * ზომას; პრივატულ ცვლადს: კვადრატის ფართობს; ღია მეთოდებს: პირველი მეთოდი
     * ღია ცვლადს მნიშვნელობას ანიჭებს; მეორე მეთოდს გამოაქვს ღია ცვლადის 
     * მნიშვნელობა; მესამე მეთოდი გამოთვლის და აბრუნებს კვადრატის ფართობს. მთავარ
     * პროგრამაში ნაგულისხმევი კონსტრუქტორის გამოყენებით შექმენით შესაბამისი ობიექტი
     * და გამოიძახეთ სამივე მეთოდი. მონაცემების შესატანად გამოიყენეთ TextBox 
     * ვიზუალური ელემენტი, გამოსატანად კი Label ვიზუალურ ელემენტი.*/
    class Kvadrati
    {
        public int gverdi_1;
        private int fartobi;
        public void minicheba(int mnishvneloba)
        {
            gverdi_1 = mnishvneloba;
        }
        public void gamotana(Label label1)
        {
            label1.Text = gverdi_1.ToString();
        }

        public int fartobisGamotvla()
        {
            return gverdi_1 * gverdi_1;
        }
        
    }
}
