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
namespace _0511_1
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
            byte ricxvi;
            FileStream file_out = new FileStream("file_1.txt", FileMode.Create);

            for (ricxvi = 36; ricxvi <= 45; ricxvi ++)
            {
                file_out.WriteByte(ricxvi);
                label1.Text += ((char)ricxvi).ToString() + "  ";
            }
            file_out.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            int ricxvi2;
            FileStream file_in = new FileStream("file_1.txt", FileMode.Open);

            for ( ; ; ) //usasrulo cikli
            {
                ricxvi2 = file_in.ReadByte();
                if (ricxvi2 != -1)
                {
                    label2.Text += ((char)ricxvi2).ToString() + "  ";
                }
                else
                {
                    break;
                }
            }
            file_in.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ricxvi1, ricxvi2;
            double ricxvi3, ricxvi4, ricxvi5;
            bool b1, b2;

            ricxvi1 = int.Parse(textBox1.Text);
            ricxvi3 = double.Parse(textBox2.Text);
            b1 = bool.Parse(textBox3.Text);


            FileStream file_out = new FileStream("file_2.dat", FileMode.Create);
            BinaryWriter bin_writer = new BinaryWriter(file_out);
            bin_writer.Write(ricxvi1);
            bin_writer.Write(ricxvi3);
            bin_writer.Write(b1);
            bin_writer.Write(123.45 * 98.123);
            bin_writer.Close();

            FileStream file_in = new FileStream("file_2.dat", FileMode.Open);
            BinaryReader bin_reader = new BinaryReader(file_in);
            ricxvi2 = bin_reader.ReadInt32();
            ricxvi4 = bin_reader.ReadDouble();
            b2 = bin_reader.ReadBoolean();
            ricxvi5 = bin_reader.ReadDouble();
            bin_reader.Close();

            label1.Text = ricxvi2.ToString() + "\n" +
                ricxvi4.ToString() + "\n" +
                b2.ToString() + "\n" +
                ricxvi5.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str1 = textBox4.Text;
            FileStream file_out = new FileStream("file3.txt", FileMode.Create);
            StreamWriter str_writer = new StreamWriter(file_out);
            str_writer.WriteLine(str1);
            str_writer.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            string str1;
            FileStream file_in = new FileStream("file3.txt", FileMode.Open);

            StreamReader str_reader = new StreamReader(file_in);
            for (; (str1 = str_reader.ReadLine()) != null;)


                label2.Text += str1 + "\n";
            str_reader.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            char symbol;

            FileStream file1 = new FileStream("file4.txt", FileMode.Create);
            for (int i = 0; i < 26; i ++)
            {
                file1.WriteByte((byte)('a' + i));
            }
            file1.Seek(0, SeekOrigin.Begin);
            symbol = (char)file1.ReadByte();
            label2.Text = symbol.ToString();

            file1.Seek(5, SeekOrigin.Begin);
            symbol = (char)file1.ReadByte();
            label3.Text = symbol.ToString();

            file1.Seek(-2, SeekOrigin.Current);
            symbol = (char)file1.ReadByte();
            label4.Text = symbol.ToString();

            file1.Seek(3, SeekOrigin.Current);
            symbol = (char)file1.ReadByte();
            label5.Text = symbol.ToString();

            file1.Seek(-4, SeekOrigin.End);
            symbol = (char)file1.ReadByte();
            label6.Text = symbol.ToString();

            file1.Close();
        }
    }
}
