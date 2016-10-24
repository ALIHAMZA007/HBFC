using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication41
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class5.a = textBox1.Text;
            Class5.b = textBox2.Text;
            Class5.c = comboBox1.Text;
            Class5.d = textBox3.Text;
            Class5.e = textBox4.Text;
            Class5.f = textBox5.Text;
            Class5.g = textBox6.Text;
            Class5.h = textBox7.Text;
            Class5.i = textBox8.Text;
            Class5.j = textBox9.Text;
            Class5.k = textBox10.Text;
            Class5.l = textBox11.Text;
            Class5.m = textBox12.Text;
            Class5 obj = new Class5();
            obj.create();
            obj.save();

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
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

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // open file dialog 
            OpenFileDialog open = new OpenFileDialog();
            // image filters
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                pictureBox1.Image = new Bitmap(open.FileName);
                // image file path

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("NEW ENTRY", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 50));
            e.Graphics.DrawString("EMPOLYEE NUMBER", new Font("Arial", 12, FontStyle.Regular),Brushes.Black, new Point(50, 100));
            e.Graphics.DrawString("EMPOLYEE NAME", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 150));
            e.Graphics.DrawString("EMPOLYEE GENDER", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 200));
            e.Graphics.DrawString("EMPOLYEE CNIC", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 250)); 
            e.Graphics.DrawString("EMPOLYEE FATHER NAME", new Font("Arial", 12,FontStyle.Regular), Brushes.Black, new Point(50, 300));
            e.Graphics.DrawString("EMPOLYEE COUNTRY", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 350));
            e.Graphics.DrawString("EMPOLYEE CITY", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 400));
            e.Graphics.DrawString("EMPOLYEE ADDRESS", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 450));
            e.Graphics.DrawString("EMPOLYEE MOBILE NUMBER", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 500));
            e.Graphics.DrawString("EMPOLYEE EMAIL", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 550));
            e.Graphics.DrawString("DATE OF EMPOLYEMENT", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 600));
            e.Graphics.DrawString("DESIGNATION" , new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 650));
            e.Graphics.DrawString("BASIC SALARY" , new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 700));
            e.Graphics.DrawString(textBox1.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 100));
            e.Graphics.DrawString(textBox2.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 150));
            e.Graphics.DrawString(comboBox1.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 200));
            e.Graphics.DrawString(textBox3.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 250));
            e.Graphics.DrawString(textBox4.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 300));
            e.Graphics.DrawString(textBox5.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 350));
            e.Graphics.DrawString(textBox6.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 400));
            e.Graphics.DrawString(textBox7.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 450));
            e.Graphics.DrawString(textBox8.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 500));
            e.Graphics.DrawString(textBox9.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 550));
            e.Graphics.DrawString(textBox10.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 600));
            e.Graphics.DrawString(textBox11.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 650));
            e.Graphics.DrawString(textBox12.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 700));
            //e.Graphics.DrawString("BASIC SALARY", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 700));





        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form8 obj = new Form8();
            obj.Show();
            this.Hide();
        }
    }
}