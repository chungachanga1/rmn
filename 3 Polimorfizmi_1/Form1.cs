using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polimorfizmi_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gverdi_1, gverdi_2, gverdi_3;
            int perim_kvad, perim_mart, perim_sam;
            double radiusi, sigrdze;

            gverdi_1 = int.Parse(textBox1.Text);
            gverdi_2 = int.Parse(textBox2.Text);
            gverdi_3 = int.Parse(textBox3.Text);
            radiusi = double.Parse(textBox4.Text);

            Figura obj_1 = new Figura();

            perim_sam = obj_1.Perimetri(gverdi_1, gverdi_2, gverdi_3);
            perim_kvad = obj_1.Perimetri(gverdi_1);
            sigrdze = obj_1.Perimetri(radiusi);
            perim_mart = obj_1.Perimetri(gverdi_1, gverdi_2);

            label1.Text = perim_kvad.ToString();
            label2.Text = perim_mart.ToString();
            label3.Text = perim_sam.ToString();
            label4.Text = sigrdze.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int gverdi_1, gverdi_2, gverdi_3;
            double radiusi;

            gverdi_1 = int.Parse(textBox1.Text);
            gverdi_2 = int.Parse(textBox2.Text);
            gverdi_3 = int.Parse(textBox3.Text);
            radiusi = double.Parse(textBox4.Text);

            Figura_1 obj_wre = new Figura_1(radiusi);
            Figura_1 obj_mart = new Figura_1(gverdi_1, gverdi_2);
            Figura_1 obj_kvad = new Figura_1(gverdi_1);
            Figura_1 obj_sam = new Figura_1(gverdi_1, gverdi_2, gverdi_3);

            obj_kvad.Gamotana_Kvad(label13);
            obj_mart.Gamotana_Mart(label14);
            obj_sam.Gamotana_Sam(label15);
            obj_wre.Gamotana_Wre(label16);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == 13) label16.Text = "jhgjhgjkhg";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class1 obj_1 = new Class1();
            Class1 obj_2 = new Class1(obj_1);
            Class1 obj_3 = new Class1(5, 8);
            label14.Text = obj_1.ricxvi_1.ToString() + "  " + obj_1.ricxvi_2.ToString();
            label15.Text = obj_2.ricxvi_1.ToString() + "  " + obj_2.ricxvi_2.ToString();
            label16.Text = obj_3.ricxvi_1.ToString() + "  " + obj_3.ricxvi_2.ToString();
        }
    }
}
