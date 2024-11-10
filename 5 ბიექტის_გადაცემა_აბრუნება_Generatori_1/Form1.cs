using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ბიექტის_გადაცემა_აბრუნება_Generatori_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            int[,] masivi_1 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] masivi_2 = new int[,] { { -1, 2, -3 }, { -4, 5, 6 }, { -7, 8, 9 } };
            int[,] masivi_3 = new int[,] { { 11, 22, 33 }, { 44, 55, 66 }, { 7, 8, 9 } };
            Class1 obj_1 = new Class1(masivi_1);
            Class1 obj_2 = new Class1(masivi_2);
            Class1 obj_3 = new Class1(masivi_3);
            int jami_1 = obj_1.Jami(obj_1);
            int jami_2 = obj_1.Jami(obj_2);
            int jami_3 = obj_2.Jami(obj_3);
            int jami_4 = obj_3.Jami(obj_1);

            label1.Text = jami_1.ToString() + "   " + jami_2.ToString() + "   " +
                          jami_3.ToString() + "   " + jami_4.ToString();

            for (int str = 0; str < masivi_1.GetLength(0); str++)
            {
                for (int sv = 0; sv < masivi_1.GetLength(1); sv++)
                    label2.Text += masivi_1[str, sv].ToString() + "  ";
                label2.Text += "\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            int[,] masivi_1 = new int[,] { { 11, 12, 13 }, { 24, 25, 26 }, { 17, 8, 9 } };
            Class3 obj_3 = new Class3();
            Class2 obj_2;
            obj_2 = obj_3.Metodi_1(masivi_1);
            label1.Text = obj_2.jami.ToString();
            for (int str = 0; str < masivi_1.GetLength(0); str++)
            {
                for (int sv = 0; sv < masivi_1.GetLength(1); sv++)
                    label2.Text += masivi_1[str, sv].ToString() + "  ";
                label2.Text += "\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            Random rand_1 = new Random();
            int zoma = int.Parse(textBox1.Text);
            int[] masivi_1 = new int[zoma];
            int indexi;

            for (indexi = 0; indexi < masivi_1.Length; indexi++)
                masivi_1[indexi] = rand_1.Next();

            foreach (int x in masivi_1)
                label3.Text += x.ToString() + "  ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            Random rand_1 = new Random();
            int zoma = int.Parse(textBox1.Text);
            int max  = int.Parse(textBox2.Text);
            int[] masivi_1 = new int[zoma];
            int indexi;

            for (indexi = 0; indexi < masivi_1.Length; indexi++)
                masivi_1[indexi] = rand_1.Next(max);

            foreach (int x in masivi_1)
                label3.Text += x.ToString() + "  ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            Random rand_1 = new Random();
            int zoma = int.Parse(textBox1.Text);
            int max = int.Parse(textBox2.Text);
            int min = int.Parse(textBox3.Text);
            int[] masivi_1 = new int[zoma];
            int indexi;

            for (indexi = 0; indexi < masivi_1.Length; indexi++)
                masivi_1[indexi] = rand_1.Next(min,max);

            foreach (int x in masivi_1)
                label3.Text += x.ToString() + "  ";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            Random rand_1 = new Random();
            int zoma = int.Parse(textBox1.Text);
            double[] masivi_1 = new double[zoma];
            int indexi;

            for (indexi = 0; indexi < masivi_1.Length; indexi++)
                masivi_1[indexi] = rand_1.NextDouble();

            foreach (double x in masivi_1)
                label3.Text += Math.Round(x,3).ToString() + "  ";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label3.Text = ""; label4.Text = "";
            Random rand_1 = new Random();
            int zoma = int.Parse(textBox1.Text);
            byte[] masivi_1 = new byte[zoma];
            sbyte[] masivi_2 = new sbyte[zoma];

            rand_1.NextBytes(masivi_1);
            for (int indexi = 0; indexi < masivi_2.Length; indexi++)
                masivi_2[indexi] = (sbyte)masivi_1[indexi];

            foreach (byte x in masivi_1)
                label3.Text += x.ToString() + "  ";
            foreach (sbyte x in masivi_2)
                label4.Text += x.ToString() + "  ";
        }
    }
}
