using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Failebi_2
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
            byte ricxvi_1;
            FileStream file_out = new FileStream("file_1.txt", FileMode.Create);

            for (ricxvi_1 = 38; ricxvi_1 <= 47; ricxvi_1++)
            {
                file_out.WriteByte(ricxvi_1);
                label1.Text += ((char)ricxvi_1).ToString() + "  ";
            }
            file_out.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            int ricxvi_1;
            FileStream file_in = new FileStream("file_1.txt", FileMode.Open);

            for ( ; ; )
            {
                ricxvi_1 = file_in.ReadByte();
                if (ricxvi_1 != -1)
                    label2.Text += ((char)ricxvi_1).ToString() + "  ";
                else break;
            }
            file_in.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ricxvi_1, ricxvi_2;
            double ricxvi_3, ricxvi_4, ricxvi_5;
            bool b_1, b_2;
            ricxvi_1 = int.Parse(textBox1.Text);
            ricxvi_3 = double.Parse(textBox2.Text);
            b_1 = bool.Parse(textBox3.Text);
            //
            FileStream file_out = new FileStream("file_2.dat", FileMode.Create);
            BinaryWriter bin_writer_1 = new BinaryWriter(file_out);
            bin_writer_1.Write(ricxvi_1);
            bin_writer_1.Write(ricxvi_3);
            bin_writer_1.Write(b_1);
            bin_writer_1.Write(ricxvi_1 * ricxvi_3);
            bin_writer_1.Close();
            //
            FileStream file_in = new FileStream("file_2.dat", FileMode.Open);
            BinaryReader bin_reader_1 = new BinaryReader(file_in);
            ricxvi_2 = bin_reader_1.ReadInt32();
            ricxvi_4 = bin_reader_1.ReadDouble();
            b_2 = bin_reader_1.ReadBoolean();
            ricxvi_5 = bin_reader_1.ReadDouble();
            bin_reader_1.Close();
            //
            label1.Text =   ricxvi_2.ToString() + "\n" +
                            ricxvi_4.ToString() + "\n" +
                            b_2.ToString() + "\n" +
                            ricxvi_5.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str_1 = textBox4.Text;
            FileStream file_out = new FileStream("file_3.txt", FileMode.Create);
            StreamWriter str_writer_1 = new StreamWriter(file_out);
            str_writer_1.WriteLine(str_1);
            str_writer_1.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string str_1;
            label1.Text = "";
            FileStream file_in = new FileStream("file_3.txt", FileMode.Open);
            StreamReader str_reader_1 = new StreamReader(file_in);
            for (; (str_1 = str_reader_1.ReadLine()) != null;)
                label1.Text += str_1 + "\n";
            str_reader_1.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            char simbolo;
            FileStream file_1 = new FileStream("file_4.txt", FileMode.Create);
            for (int i = 0; i < 26; i++)
                file_1.WriteByte((byte)('a' + i));
            //
            file_1.Seek(0, SeekOrigin.Begin);
            simbolo = (char)file_1.ReadByte(); // a
            label3.Text = simbolo.ToString();

            file_1.Seek(5, SeekOrigin.Begin);
            simbolo = (char)file_1.ReadByte(); // f
            label4.Text = simbolo.ToString();
            //
            file_1.Seek(-2, SeekOrigin.Current);
            simbolo = (char)file_1.ReadByte(); // e
            label5.Text = simbolo.ToString();

            file_1.Seek(4, SeekOrigin.Current);
            simbolo = (char)file_1.ReadByte(); // j
            label6.Text = simbolo.ToString();

            file_1.Seek(-4, SeekOrigin.End);
            simbolo = (char)file_1.ReadByte(); // w
            label7.Text = simbolo.ToString();
            //
            file_1.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            byte[] masivi_1 = new byte[] { 56, 57, 58, 59, 60, 61, 62, 63, 64, 65 };
            FileStream file_out = new FileStream("file_4.txt", FileMode.Create);
            //file_out.Write(masivi_1, 3, 4);
            file_out.Write(masivi_1, 0, 10);
            file_out.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            byte[] masivi_1 = new byte[10]; // 0 0 0 0 0 0 0 0 0 0 
            FileStream file_in = new FileStream("file_4.txt", FileMode.Open);
            int baitebi = file_in.Read(masivi_1, 2, 5);
            //int baitebi = file_in.Read(masivi_1, 0, 10);
            file_in.Close();
            for (int indexi = 0; indexi < masivi_1.Length; indexi++)
                label1.Text += masivi_1[indexi].ToString() + " ";
            label2.Text = baitebi.ToString();
        }
    }
}
