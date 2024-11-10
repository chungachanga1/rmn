using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsulacia_1
{
    /*შექმენით სტუდენტის კლასი, რომელიც შეიცავს ღია მეთოდს. მეთოდს გადაეცემა 
     * სტუდენტის ნიშნები, რომლებიც წარმოადგენენ 10-ელემენტიან მთელრიცხვა მასივს, 
     * მეთოდი გამოთვლის და აბრუნებს ნიშნების საშუალო არითმეტიკულს. მთავარ 
     * პროგრამაში ნაგულისხმევი კონსტრუქტორის გამოყენებით შექმენით შესაბამისი 
     * ობიექტი და გამოიძახეთ ეს მეთოდი. მასივი და შედეგი გამოიტანეთ Label 
     * ვიზუალურ ელემენტში.*/
    class Studenti
    {
        public double Sashualo_1(int[] masivi_1)
        {
            int jami = 0;
            for (int indexi = 0; indexi < masivi_1.Length; indexi++)
                jami += masivi_1[indexi];
            return (double)jami / masivi_1.Length;
        }
    }
}
