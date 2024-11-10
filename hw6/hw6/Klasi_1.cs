using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw6
/*შექმენით Klasi_1 კლასი, რომელიც შეიცავს: მთელი ტიპის ერთგანზომილებიან
სტატიკურ მასივს, რომლის ინიციალიზებას კონსტრუქტორი ახდენს; პრივატულ
ჩვეულებრივ მეთოდს, რომელიც ერთგანზომილებიანი სტატიკური მასივის კენტი
ელემენტების ჯამს გასცემს; ღია სტატიკურ მეთოდს, რომელიც ჩვეულებრივ
მეთოდს იძახებს და გასცემს შედეგს. მთავარ პროგრამაში შექმენით ობიექტი
კონსტრუქტორის გამოყენებით და გამოიძახეთ სტატიკური მეთოდი.*/

{
    class Klasi_1
    {
        static int[] masivi;

        public Klasi_1(int[] masivi)
        {
            Klasi_1.masivi = masivi;
        }

        private int chveulebriviMetodi()
        {
            int jami = 0;
            for (int i = 0; i < masivi.Length; i ++)
            {
                if(masivi[i] % 2 != 0)
                {
                    jami += masivi[i];
                }
            }
            return jami;
        }

        public static int gamodzaxeba()
        {
            Klasi_1 obj1 = new Klasi_1(masivi);
            return obj1.chveulebriviMetodi();
        }
        
    }
}
