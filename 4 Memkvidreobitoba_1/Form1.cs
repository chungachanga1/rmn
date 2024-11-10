using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memkvidreobitoba_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pirovneba obj_pirovneba = new Pirovneba();
            obj_pirovneba.gvari = "";

            Studenti obj_studenti = new Studenti();
            obj_studenti.gvari = "";
            obj_studenti.staji = 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int gverdi_1, gverdi_2, gverdi_3;
            int perimetri_kvadrati, perimetri_martkutxedi, perimetri_samkutxedi;
            int fartobi_kvadrati, fartobi_martkutxedi;
            double fartobi_samkutxedi;

            gverdi_1 = int.Parse(textBox1.Text);
            gverdi_2 = int.Parse(textBox2.Text);
            gverdi_3 = int.Parse(textBox3.Text);

            Martkutxedi obj_martkutxedi = new Martkutxedi(gverdi_1, gverdi_2);
            Kvadrati obj_kvadrati = new Kvadrati(gverdi_1);
            Samkutxedi obj_samkutxedi = new Samkutxedi(gverdi_1, gverdi_2, gverdi_3);

            perimetri_kvadrati = obj_kvadrati.Perimetri_Kvadrati();
            fartobi_kvadrati = obj_kvadrati.Fartobi_Kvadrati();
            perimetri_martkutxedi = obj_martkutxedi.Perimetri_Martkutxedi();
            fartobi_martkutxedi = obj_martkutxedi.Fartobi_Martkutxedi();
            perimetri_samkutxedi = obj_samkutxedi.Perimetri_Samkutxedi();
            fartobi_samkutxedi = obj_samkutxedi.Fartobi_Samkutxedi();

            label1.Text = "კვადრატის პერიმეტრი = " + perimetri_kvadrati.ToString();
            label2.Text = "კვადრატის ფართობი = " + fartobi_kvadrati.ToString();
            label3.Text = "მართკუთხედის პერიმეტრი = " + perimetri_martkutxedi.ToString();
            label4.Text = "მართკუთხედის ფართობი = " + fartobi_martkutxedi.ToString();
            label5.Text = "სამკუთხედის პერიმეტრი = " + perimetri_samkutxedi.ToString();
            label6.Text = "სამკუთხედის ფართობი = " + fartobi_samkutxedi.ToString();
        }
    }
}
