using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2210_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] masivi_1 = new int[,] { { 11, 12, 13 }, { 14, 15, 16 }, { 17, 28, 29 } };
            Class2 obj_2 = new Class2();
            Class1 obj1;
            obj1 = obj_2.Metodi1(masivi_1);
            label1.Text = obj1.jami.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            Random rand1 = new Random();
            int zoma = int.Parse(textBox1.Text);

            int[] masivi1 = new int[zoma];

            for(int indexi = 0; indexi < masivi1.Length; indexi ++)
            {
                masivi1[indexi] = rand1.Next();
            }
            foreach (int x in masivi1)
            {
                label3.Text += x.ToString() + "  ";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            Random rand1 = new Random();
            int zoma = int.Parse(textBox1.Text);
            int max = int.Parse(textBox2.Text);
            int[] masivi1 = new int[zoma];

            for (int indexi = 0; indexi < masivi1.Length; indexi++)
            {
                masivi1[indexi] = rand1.Next(max);
            }
            foreach (int x in masivi1)
            {
                label4.Text += x.ToString() + "  ";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            Random rand1 = new Random();
            int zoma = int.Parse(textBox1.Text);
            int max = int.Parse(textBox2.Text);
            int min = int.Parse(textBox3.Text);

            int[] masivi1 = new int[zoma];

            for (int indexi = 0; indexi < masivi1.Length; indexi++)
            {
                masivi1[indexi] = rand1.Next(min, max);
            }
            foreach (int x in masivi1)
            {
                label5.Text += x.ToString() + "  ";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label6.Text = "";
            int zoma = int.Parse(textBox4.Text);
            double[] masivi1 = new double[zoma];
            Random rand1 = new Random();

            for(int indexi =0; indexi < zoma; indexi++)
            {
                masivi1[indexi] = Math.Round(rand1.NextDouble(), 3);
            }
            foreach (double x in masivi1)
            {
                label5.Text += x.ToString() + "  ";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label7.Text = "";
            Random rand1 = new Random();
            int zoma = int.Parse(textBox5.Text);
            byte[] masivi1 = new byte[zoma];

            rand1.NextBytes(masivi1);

            foreach (byte x in masivi1)
            {
                label7.Text += x.ToString() + "  ";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
