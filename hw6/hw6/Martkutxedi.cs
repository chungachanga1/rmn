using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw6
{

    /*2.შექმენით Martkutxedi კლასი, რომელიც შეიცავს სტატიკურ ცვლადებს -
მართკუთხედის გვერდებს და ჩვეულებრივ ცვლადს - მართკუთხედის
პერიმეტრს. შეიცავს კონსტრუქტორს, რომელიც სტატიკური ცვლადების
ინიციალიზებას ასრულებს და პრივატულ ჩვეულებრივ მეთოდს, რომელიც
ანგარიშობს და გასცემს მართკუთხედის პერიმეტრის მნიშვნელობას. შეიცავს ღია
სტატიკურ მეთოდს, რომელიც ჩვეულებრივ მეთოდს იძახებს და გასცემს
პერიმეტრის მნიშვნელობას. მთავარ პროგრამაში შექმენით ობიექტი
კონსტრუქტორის გამოყენებით და გამოიძახეთ სტატიკური მეთოდი.*/
    class Martkutxedi
    {
        static int gverdi1, gverdi2;
        int perimetri;

        public Martkutxedi(int gverdi1, int gverdi2)
        {
            Martkutxedi.gverdi1 = gverdi1;
            Martkutxedi.gverdi2 = gverdi2;
        }

        private int perimetrisGamotvla()
        {
            perimetri = 2 * (gverdi1 + gverdi2);
            return perimetri;
        }

        public static int statikuriMetodi()
        {
            Martkutxedi obj1 = new Martkutxedi(gverdi1, gverdi2);
            return obj1.perimetrisGamotvla();
        }
    }


}
