using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication41
{
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox3.Text != "" && textBox4.Text != "" && comboBox1.Text != "" && textBox6.Text!="" )
            {
                textBox9.Text = textBox3.Text;
                textBox5.Text = Convert.ToString((Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox4.Text)) / 100);
                textBox8.Text = Convert.ToString(Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox5.Text));
                textBox7.Text = Convert.ToString(Convert.ToInt32(textBox8.Text) / Convert.ToInt32(textBox6.Text));


            }

            else
            {
                MessageBox.Show("Fill IT Completely");
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class11.a = textBox1.Text;
            Class11.b = comboBox1.Text;
            Class11.c = textBox3.Text;
            Class11.d = textBox4.Text;
            Class11.e = textBox5.Text;
            Class11.f = textBox6.Text;
            Class11.g = textBox7.Text;
            Class11.h = textBox8.Text;
            Class11.i = textBox9.Text;
            Class11 obj = new Class11();
            obj.hum();
            obj.geo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("NAME",new Font("Arial",12,FontStyle.Regular),Brushes.Black,new Point(50,50));
            e.Graphics.DrawString("LOAN PURPOSE",new Font("Arial",12,FontStyle.Regular),Brushes.Black,new Point(50,100));
         e.Graphics.DrawString("LOAN AMOUNT APPROVED",new Font("Arial",12,FontStyle.Regular),Brushes.Black,new Point(50,150));
         e.Graphics.DrawString("INTEREST(IN %)", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 200));
         e.Graphics.DrawString("INTEREST(IN RUPEES)", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 250));
         e.Graphics.DrawString("PERIOD(IB MONTH)", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 300));
         e.Graphics.DrawString("MONTHLY INSTALLMENT", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 350));
         e.Graphics.DrawString("TOTAL AMOUNT PAID BY CUSTOMER", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 400));
         e.Graphics.DrawString("TOTAL AMOUNT PAID TO CUSTOMER", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 450));
         e.Graphics.DrawString(textBox1.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 50));
         e.Graphics.DrawString(comboBox1.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 150));
         e.Graphics.DrawString(textBox3.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 200));
         e.Graphics.DrawString(textBox4.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 250));
         e.Graphics.DrawString(textBox5.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 300));
         e.Graphics.DrawString(textBox6.Text, new Font("PERIOD (IN MONTH)", 12, FontStyle.Regular), Brushes.Black, new Point(400, 350));
         e.Graphics.DrawString(textBox7.Text, new Font("MONTHLY INSTALLMENT", 12, FontStyle.Regular), Brushes.Black, new Point(400, 400));
         e.Graphics.DrawString(textBox8.Text, new Font("TOTAL AMOUNT PAID BY CUSTOMER", 12, FontStyle.Regular), Brushes.Black, new Point(400, 450));
         e.Graphics.DrawString(textBox9.Text, new Font("TOTAL AMOUNT PAID TO CUSOMER", 12, FontStyle.Regular), Brushes.Black, new Point(400, 500));








         
        
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Class12.a = textBox1.Text;
            comboBox1.Text = Class12.b;
            textBox3.Text = Class12.c;
            textBox4.Text = Class12.d;
            textBox5.Text = Class12.e;
            textBox6.Text = Class12.f;
            textBox7.Text = Class12.g;
            textBox8.Text = Class12.h;
            textBox9.Text = Class12.i;
            Class12 obj = new Class12();
            obj.Search();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Class8.a = textBox1.Text;
            Class8 obj = new Class8();
            obj.erase();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form12 obj = new Form12();
            obj.Show();
            this.Hide();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}