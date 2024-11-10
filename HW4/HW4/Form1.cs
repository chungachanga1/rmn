using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gverdi_1, gverdi_2, gverdi_3;
            int perimetri_samkutxedi;
            int fartobi_kvadrati;

            gverdi_1 = int.Parse(textBox1.Text);
            gverdi_2 = int.Parse(textBox2.Text);
            gverdi_3 = int.Parse(textBox3.Text);

            Kvadrati obj_kvadrati = new Kvadrati(gverdi_1);
            Samkutxedi obj_samkutxedi = new Samkutxedi(gverdi_1, gverdi_2, gverdi_3);

            fartobi_kvadrati = obj_kvadrati.Fartobis_gamotvla();
            perimetri_samkutxedi = obj_samkutxedi.Perimeteris_gamotvla();

            label6.Text = perimetri_samkutxedi.ToString();
            label7.Text = fartobi_kvadrati.ToString();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int moxmareba1saatshi, chartvisxangrdzlivoba, daxarjuliVatebisRaodenoba;
            moxmareba1saatshi = int.Parse(textBox4.Text);
            chartvisxangrdzlivoba = int.Parse(textBox5.Text);
            daxarjuliVatebisRaodenoba = int.Parse(textBox6.Text);

            Memkvidre_1 obj_memkvidre = new Memkvidre_1(moxmareba1saatshi, chartvisxangrdzlivoba, daxarjuliVatebisRaodenoba);

            obj_memkvidre.Gamotana(label11, label12, label13);

        }
    }
}
