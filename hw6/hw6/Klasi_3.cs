using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw6
{
    /*შექმენით კლასი, რომელშიც პრივატული მთელი ტიპის ცვლადია გამოცხადებული.
მასთან მიმართვისათვის გამოიყენეთ თვისება, რომელშიც set და get მეთოდებია
განსაზღვრული. თვისება პრივატულ ცვლადს კენტ მნიშვნელობებს ანიჭებს.*/
    class Klasi_3
    {
        private int ricxvi;
        public int tviseba
        {
            get
            {
                return ricxvi;
            }

            set
            {
                if (value % 2 != 0)
                {
                    ricxvi = value ;
                }
                else
                {
                    ricxvi = value + 1;
                }

            }
        }
    }
}
