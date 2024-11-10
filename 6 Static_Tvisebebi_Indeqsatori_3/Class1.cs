using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Tvisebebi_Indeqsatori_3
{
    class Class1
    {
        public const int mudmiva_1 = 10;
        public int chveulebrivi_cvladi;
        private static int statikuri_cvladi;
        private int Chveulebrivi_Metodi_1(int p1, int p2)
        {
            chveulebrivi_cvladi = p1;
            statikuri_cvladi = p2;
            return chveulebrivi_cvladi + statikuri_cvladi + mudmiva_1;
        }
        public static int Statikuri_Metodi_1(Class1 par_obj, int p1, int p2)
        {
            return par_obj.Chveulebrivi_Metodi_1(p1, p2);
        }
    }
}
