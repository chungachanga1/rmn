using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4
/*3. შექმენით ტელევიზორის საბაზო კლასი - Televizori. მასში გამოაცხადეთ დაცული
ცვლადები: ტელევიზორი 1 საათში რამდენ ვატს მოიხმარს და რამდენი საათის
განმავლობაშია ჩართული, და კონსტრუქტორი, რომელიც დაცულ წევრებს
მნიშვნელობებს ანიჭებს. შექმენით Televizori კლასის მემკვიდრე კლასი -
Memkvidre_1. მასში გამოაცხადეთ პრივატული ცვლადი - ტელევიზორის მიერ
დახარჯული (მოხმარებული) ვატების რაოდენობა. გამოაცხადეთ
კონსტრუქტორი, რომელიც იძახებს წინაპარი კლასის კონსტრუქტორს
მემკვიდრეობითობით მიღებული ცვლადების ინიციალიზების მიზნით. თვით ეს
კონსტრუქტორი ახდენს ამავე კლასის ცვლადის ინიციალიზებას. ამავე კლასში
განსაზღვრეთ ღია მეთოდი, რომელსაც ეკრანზე გამოაქვს ყველა ცვლადის
მნიშვნელობა. მთავარ პროგრამაში შექმენით მემკვიდრე კლასის ტიპის მქონე
ობიექტი და გამოიძახეთ მეთოდი.
*/
{
    class Televizori
    {
        protected int moxmareba1saatshi, chartvisxangrdzlivoba;

        public Televizori(int moxmareba1saatshi, int chartvisxangrdzlivoba)
        {
            this.moxmareba1saatshi = moxmareba1saatshi;
            this.chartvisxangrdzlivoba = chartvisxangrdzlivoba;
        }
    }

    class Memkvidre_1 : Televizori
    {
        private int daxarjuliVatebisRaodenoba;

        public Memkvidre_1(int moxmareba1saatshi, int chartvisxangrdzlivoba, int daxarjuliVatebisRaodenoba) : base(moxmareba1saatshi, chartvisxangrdzlivoba)
        {
            this.daxarjuliVatebisRaodenoba = daxarjuliVatebisRaodenoba;
        }
        public void Gamotana(Label label1, Label label2, Label label3)
        {
            label1.Text = moxmareba1saatshi.ToString(); 
            label2.Text = chartvisxangrdzlivoba.ToString(); 
            label3.Text = daxarjuliVatebisRaodenoba.ToString();
        }

    }


}