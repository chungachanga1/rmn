using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Static_Tvisebebi_Indeqsatori_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ricxvi_1, ricxvi_2, jami;
            ricxvi_1 = int.Parse(textBox1.Text);
            ricxvi_2 = int.Parse(textBox2.Text);
            Class1 obj_1 = new Class1();

            jami = Class1.Statikuri_Metodi_1(obj_1, ricxvi_1, ricxvi_2) - Class1.mudmiva_1;

            label1.Text = jami.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ricxvi_1 = int.Parse(textBox1.Text);
            Class2 obj_1 = new Class2();

            obj_1.tviseba_int = ricxvi_1;
            label1.Text = obj_1.tviseba_int.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str_1 = textBox1.Text;
            Class2 obj_1 = new Class2();

            obj_1.tviseba_string = str_1;
            label1.Text = obj_1.tviseba_string;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            Random rand_1 = new Random();
            Class3 obj_1 = new Class3();

            for (int indexi = 0; indexi < 5; indexi++)
                obj_1[indexi] = rand_1.Next(21);

            for (int indexi = 0; indexi < 5; indexi++)
                label1.Text += obj_1[indexi].ToString() + "  ";            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            Random rand_1 = new Random();
            Class4 obj_1 = new Class4();

            for (int indexi = 0; indexi < 5; indexi++)
                obj_1[indexi] = (char)rand_1.Next(33, 100);

            for (int indexi = 0; indexi < 5; indexi++)
                label1.Text += obj_1[indexi].ToString() + "  ";
        }
    }
}
