using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sivrce_1;
using Sivrce_1.Sivrce_11;
using Toyota;
//using BMW;    ERROR!!!

namespace Konstructori_This_Sivrce_3
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
            gverdi_1 = int.Parse(textBox1.Text);
            gverdi_2 = int.Parse(textBox2.Text);
            gverdi_3 = int.Parse(textBox3.Text);
            Samkutxedi obj_samkutxedi = new Samkutxedi(gverdi_1, gverdi_2, gverdi_3);
            obj_samkutxedi.Gamotana(label1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            double[,] masivi_1 = new double[,] { { 1.1, 2.2, -3.3 },{ 4.4, -5.5, -6.6 },{ 7.7, 8.8, 9.9 }};
            Class1 obj_1 = new Class1();
            double uaryofiti = obj_1.Uaryofiti_1(masivi_1);
            label1.Text = uaryofiti.ToString();
            for (int str = 0; str < masivi_1.GetLength(0); str++)
            {
                for (int sv = 0; sv < masivi_1.GetLength(1); sv++)
                    label2.Text += masivi_1[str, sv] + "   ";
                label2.Text += "\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BMW.Manqana obj_Bmw = new BMW.Manqana();
            Toyota.Manqana obj_Toyota = new Toyota.Manqana();
            obj_Bmw.marka = textBox1.Text;
            label1.Text = obj_Bmw.marka;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Manqana obj_Toyota = new Manqana();
            BMW.Manqana obj_Bmw = new BMW.Manqana();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sivrce_1.Klasi_1 obj_1 = new Sivrce_1.Klasi_1();
            Sivrce_1.Sivrce_11.Klasi_11 obj_11 = new Sivrce_1.Sivrce_11.Klasi_11();
            
        }
    }
}
