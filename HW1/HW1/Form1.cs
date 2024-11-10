using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tvitmprinavi obj_1 = new Tvitmprinavi();
            int gayiduli_biletebi = int.Parse(textBox1.Text);
            int mgzavrebis_raodenoba = int.Parse(textBox2.Text);

            obj_1.mgzavrebis_raodenoba = mgzavrebis_raodenoba;
            obj_1.gayiduli_biletebi = gayiduli_biletebi;

            label1.Text = obj_1.gayiduli_biletebi.ToString();
            label2.Text = obj_1.mgzavrebis_raodenoba.ToString();


            //obj_1.Gayiduli_biletebi_minicheba(gayiduli_biletebi);
            //         obj_1.Mgzavrebis_raodenoba_minicheba(mgzavrebis_raodenoba);
            //        obj_1.Biletebis_gamotana(label1);
            //      obj_1.Mgzavrebis_gamotana(label2);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Automobile obj_1 = new Automobile();
            string mflobeli = textBox3.Text;
            string mwarmoebeli = textBox4.Text;

            obj_1.owner_surname = mflobeli;
            obj_1.manufacturer = mwarmoebeli;

            label3.Text = obj_1.owner_surname;
            label4.Text = obj_1.manufacturer;


            /*
             * eseni pirobashi ar weria, chemtvis vvarjishobdi da magitomacaa dakomentarebuli 
            obj_1.Mflobelis_minicheba(mflobeli);
            obj_1.Mwarmoeblis_minicheba(mwarmoebeli);
            obj_1.Mflobelis_gamotana(label3);
            obj_1.Mwarmoeblis_gamotana(label4);
            */
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Matarebeli obj_1 = new Matarebeli();
            int gayiduli_biletebi = int.Parse(textBox5.Text);
            int vagonebis_tevadoba = int.Parse(textBox6.Text);
            double biletis_fasi = double.Parse(textBox7.Text);
            int gayiduli_biletebis_raodenoba = int.Parse(textBox8.Text);
            obj_1.Minicheba(gayiduli_biletebi, vagonebis_tevadoba, biletis_fasi, gayiduli_biletebis_raodenoba);
            obj_1.Gamotana(label5, label6, label7, label8);
            double shemosavali = obj_1.Gamotvla();
            label9.Text = shemosavali.ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
