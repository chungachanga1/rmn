using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1
{
    /*1. შექმენით თვითმფრინავის კლასი, რომელიც შეიცავს პრივატულ ცვლადებს: ბაკის
ტევადობა და მანძილი, რომელსაც თვითმფრინავი 1 ლიტრი საწვავით გაიფრენს;
ღია ცვლადებს: მგზავრების რაოდენობა და გაყიდული ბილეთების რაოდენობა.
მთავარ პროგრამაში ნაგულისხმევი კონსტრუქტორის გამოყენებით შექმენით
შესაბამისი ობიექტი. მის ღია ცვლადებს მიანიჭეთ მნიშვნელობები TextBox
ვიზუალური ელემენტიდან. ეს მნიშვნელობები გამოიტანეთ Label ვიზუალურ
ელემენტში.
     */
    class Tvitmprinavi
    {
        private int bakis_tevadoba;
        private int mandzili;
        public int mgzavrebis_raodenoba;
        public int gayiduli_biletebi;

        /*
        public void Mgzavrebis_raodenoba_minicheba(int par_1)
        {
            mgzavrebis_raodenoba = par_1;
        }
        public void Gayiduli_biletebi_minicheba(int par_1)
        {
            gayiduli_biletebi = par_1;
        }
        public void Mgzavrebis_gamotana(Label lab_1)
        {
            lab_1.Text = mgzavrebis_raodenoba.ToString();
        }
        public void Biletebis_gamotana(Label lab_1)
        {
            lab_1.Text = gayiduli_biletebi.ToString();
        }
        */
    }

}
