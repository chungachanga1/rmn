using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            int gverdi1 = int.Parse(textBox1.Text);
            int gverdi2 = int.Parse(textBox2.Text);

            //Martkutxedi obj1 = new Martkutxedi(gverdi1, gverdi2);
            new Martkutxedi(gverdi1, gverdi2);

            int perimetri = Martkutxedi.statikuriMetodi();

            label1.Text = perimetri.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] masivi = new int[10];

            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                masivi[i] = rand.Next(1, 100);
            }

            //Klasi_1 obj1 = new Klasi_1(masivi);
            new Klasi_1(masivi);
            int jami = Klasi_1.gamodzaxeba();
            label2.Text = jami.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[,] masivi = new int[,] { { 11, 12, 13 }, { 14, 15, 16 }, { 17, 28, 29 } };
            new Klasi_2(masivi);
            label3.Text = Klasi_2.statikuriMetodi().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Klasi_3 obj1 = new Klasi_3();
            int ricxvi = int.Parse(textBox3.Text);
            obj1.tviseba = ricxvi;
            label4.Text = obj1.tviseba.ToString();
        }
    }
}
