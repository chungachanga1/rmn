using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ბიექტის_გადაცემა_აბრუნება_Generatori_1
{
    class Class1
    {
        private int[,] masivi_1;
        private int jami_luwi;
        public Class1(int[,] masivi_1)
        {
            this.masivi_1 = masivi_1;
        }
        public int Jami(Class1 obj_par)
        {
            obj_par.jami_luwi = 0;
            for (int str = 0; str < obj_par.masivi_1.GetLength(0); str++)
                for (int sv = 0; sv < obj_par.masivi_1.GetLength(1); sv++)
                    if (obj_par.masivi_1[str, sv] % 2 == 0)
                        obj_par.jami_luwi += obj_par.masivi_1[str, sv];
            return obj_par.jami_luwi;
        }
    }
}
