using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw6
/*4.შექმენით Klasi_2 კლასი, რომელიც შეიცავს: მთელი ტიპის ორგანზომილებიან
სტატიკურ მასივს, რომლის ინიციალიზებას კონსტრუქტორი ახდენს; პრივატულ
ჩვეულებრივ მეთოდს, რომელიც ორგანზომილებიანი სტატიკური მასივის კენტი
ელემენტების რაოდენობას გასცემს; ღია სტატიკურ მეთოდს, რომელიც
ჩვეულებრივ მეთოდს იძახებს და გასცემს შედეგს. მთავარ პროგრამაში შექმენით
ობიექტი კონსტრუქტორის გამოყენებით და გამოიძახეთ სტატიკური მეთოდი.*/
{
    class Klasi_2
    {
        static int[,] statikuriMasivi;
        public Klasi_2(int[,] statikuriMasivi)
        {
            Klasi_2.statikuriMasivi = statikuriMasivi;
        }

        private int chveulebriviMetodi()
        {
            int raodenoba = 0;
            for (int i = 0; i < statikuriMasivi.GetLength(0); i ++)
            {
                for (int j = 0; j < statikuriMasivi.GetLength(1); j ++)
                {
                    if (statikuriMasivi[i,j] % 2 != 0)
                    {
                        raodenoba += 1;
                    }
                }
            }
            return raodenoba;
        }

        public static int statikuriMetodi()
        {
            Klasi_2 obj1 = new Klasi_2(statikuriMasivi);
            return obj1.chveulebriviMetodi();
        }
    }
}
