using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsApplication41
{
    public partial class Form13 : Form
    {
        string bol = null;
        public Form13()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class9.a = textBox1.Text;
            Class9.b = textBox2.Text;
            Class9.c = textBox3.Text;
            Class9.d = textBox4.Text;
            Class9.e = textBox5.Text;
            Class9.f = textBox6.Text;
            Class9.g = textBox7.Text;
            Class9.h = textBox8.Text;
            Class9 obj = new Class9();
            obj.make();
            obj.save();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {
                textBox7.Text = Convert.ToString(Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox6.Text));

            }
            else
            {
                MessageBox.Show("Insert The Complete Information");
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           //Class10.ab = textBox1.Text;
            //Class10.ac = textBox2.Text;
            //Class10.aj = textBox8.Text;
            //textBox3.Text = Class10.ad;
            //textBox4.Text = Class10.ae;
           // textBox5.Text = Class10.af;
            //textBox6.Text = Class10.ah;
            //textBox7.Text = Class10.ai;
            
            //Class10 obj = new Class10();
            //obj.search();
            bol=@"D:\salary\" + textBox1.Text + textBox2.Text + textBox8.Text + ".txt";
            FileStream fs = null;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox8.Text == "")
            {
                MessageBox.Show("Please Enter The Empolyee Number Empolyee name and Date");
            }
            else if (File.Exists(bol))
            {
                using (StreamReader obj = new StreamReader(bol))
                {
                    textBox3.Text=obj.ReadLine();
                    textBox4.Text=obj.ReadLine();
                    textBox5.Text = obj.ReadLine();




                }
            }
            else
            {
                MessageBox.Show("File Not Exists");
            
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Salary For Empolyee", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 50));
            e.Graphics.DrawString(" Empolyee no", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 100));
            e.Graphics.DrawString(" Date of Recieve", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 150));
            e.Graphics.DrawString("Name", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 200));
            e.Graphics.DrawString("MOnth", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 250));
            e.Graphics.DrawString("Gross Salary", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 300));
            e.Graphics.DrawString("HRA", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 350));
            e.Graphics.DrawString("DA", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 400));
            e.Graphics.DrawString("Total Salary", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 450));
            e.Graphics.DrawString(textBox8.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 100));
            e.Graphics.DrawString(textBox1.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 150));
            e.Graphics.DrawString(textBox2.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 200));
            e.Graphics.DrawString(textBox3.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 250));
            e.Graphics.DrawString(textBox4.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 300));
            e.Graphics.DrawString(textBox5.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 350));
            e.Graphics.DrawString(textBox6.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 400));
            e.Graphics.DrawString(textBox7.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 450));
           // e.Graphics.DrawString("Total Salary", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 450));

        }

        private void button5_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form12 obj = new Form12();
            obj.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
          


        }
    }
}