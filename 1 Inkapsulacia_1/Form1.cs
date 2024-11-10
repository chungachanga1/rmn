using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inkapsulacia_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kvadrati obj_kvadrati_1 = new Kvadrati();
            int gverdi_1, fartobi;
            gverdi_1 = int.Parse(textBox1.Text);
            obj_kvadrati_1.minicheba(gverdi_1);
            obj_kvadrati_1.gamotana(label1);
            fartobi = obj_kvadrati_1.fartobisGamotvla();
            label2.Text = fartobi.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = "";
            Studenti obj_studenti = new Studenti();
            int[] masivi_1 = new int[] { 99, 91, 94, 98, 92, 95, 94, 97, 96, 100 };
            double sashualo = obj_studenti.Sashualo_1(masivi_1);
            label5.Text = sashualo.ToString();
            foreach (int x in masivi_1)
                label6.Text += x.ToString() + "   ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Studenti_1 obj_studenti_1 = new Studenti_1();
            string gvari, saxeli;
            int asaki;
            gvari = textBox2.Text;
            saxeli = textBox3.Text;
            asaki = int.Parse(textBox4.Text);
            obj_studenti_1.Minicheba(gvari, saxeli, asaki);
            obj_studenti_1.Gamotana_1(label8);
        }
    }
}
