using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2210_2
{
    class Class1
    {
        public int jami;
        public Class1(int jami)
        {
            this.jami = jami;
        }
    }
    class Class2
    {
        public Class1 Metodi1(int[,] masivi1)
        {
            int jami = 0;
            for (int str = 0; str < masivi1.GetLength(0); str++)
            {
                for (int sv = 0; sv < masivi1.GetLength(1); sv++)
                {
                    if (masivi1[str, sv] >= 15 && masivi1[str, sv] <= 25)
                    {
                        jami += masivi1[str, sv];
                    }
                }
            }
            return new Class1(jami);
        }
    }
}
