using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstructori_This_Sivrce_3
{
    /*შექმენით კლასი, რომელშიც განსაზღვრულ მასივსა და მეთოდის პარამეტრს ერთნაირი 
     * სახელები აქვს. პარამეტრის მნიშვნელობა მიანიჭეთ კლასის ამავე სახელის მქონე მასივს. 
     * მეთოდი აბრუნებს მასივის პირველ უარყოფით ელემენტს.
     მთავარ პროგრამაში შექმენით ობიექტი ნაგულისხმევი კონსტრუქტორის გამოყენებით და 
     გამოიძახეთ მეთოდი. გამოსატანად კი - Label ვიზუალური ელემენტი.*/
    class Class1
    {
        double[,] masivi_1; // მასივზე მიმართვა
        int str, sv;
        public double Uaryofiti_1(double[,] masivi_1)
        {
            //int str, sv;
            this.masivi_1 = masivi_1;            
            for (str = 0; str < this.masivi_1.GetLength(0); str++)
            {
                for (sv = 0; sv < this.masivi_1.GetLength(1); sv++)
                    if (this.masivi_1[str, sv] >= 0) continue;
                    else return this.masivi_1[str, sv];
            }
            return 0;
        }
    }
}
