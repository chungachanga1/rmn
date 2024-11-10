using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polimorfizmi_1
{
    class Class1
    {
        public int ricxvi_1, ricxvi_2;
        public Class1(int par_1, int par_2)
        {
            ricxvi_1 = par_1;
            ricxvi_2 = par_2;
        }
        public Class1() : this(0,0)
        {

        }
        public Class1(Class1 par_obj) : this (par_obj.ricxvi_1, par_obj.ricxvi_2)
        {

        }
    }
}
