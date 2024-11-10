using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    /*5. შექმენით ავტომანქანის კლასი, რომელიც შეიცავს პრივატულ ცვლადებს: მანქანის
ფერი და კარებების რაოდენობა; ღია ცვლადებს: მფლობელის გვარი და
გამომშვები ფირმა. მთავარ პროგრამაში ნაგულისხმევი კონსტრუქტორის
გამოყენებით შექმენით შესაბამისი ობიექტი. მის ღია ცვლადებს მიანიჭეთ
მნიშვნელობები TextBox ვიზუალური ელემენტიდან. ეს მნიშვნელობები
გამოიტანეთ Label ვიზუალურ ელემენტში.*/

    class Automobile
    {
        private string color;
        private string door_count;
        public string owner_surname, manufacturer;

        /*
         * 
         * eseni pirobashi ar weria, chemtvis vvarjishobdi da magitomacaa dakomentarebuli 



        public void Mflobelis_minicheba(string par_1)
        {
            owner_surname = par_1;
        }
        public void Mwarmoeblis_minicheba(string par_1)
        {
            manufacturer = par_1;
        }

        public void Mflobelis_gamotana(Label lab_1)
        {
            lab_1.Text = owner_surname;
        }
        public void Mwarmoeblis_gamotana(Label lab_1)
        {
            lab_1.Text = manufacturer;
        }
        */
    }
}
