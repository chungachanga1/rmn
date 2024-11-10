using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ბიექტის_გადაცემა_აბრუნება_Generatori_1
{
    class Class2
    {
        public int jami;
        public Class2(int jami)
        {
            this.jami = jami;
        }
    }
    class Class3
    {
        public Class2 Metodi_1(int[,] masivi_1)
        {
            int jami = 0;
            for (int str = 0; str < masivi_1.GetLength(0); str++)
                for (int sv = 0; sv < masivi_1.GetLength(1); sv++)
                    if (masivi_1[str, sv] >= 15 && masivi_1[str, sv] <= 25)
                        jami += masivi_1[str, sv];
            return new Class2(jami);
        }
    }
}
