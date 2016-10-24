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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class10.ab = richTextBox1.Text;
            textBox1.Text = Class10.ac;
            textBox2.Text = Class10.ad;
            textBox3.Text = Class10.ae;
            textBox4.Text = Class10.af;
            textBox5.Text = Class10.ag;
            Class10 obj = new Class10();
            obj.search();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            if (richTextBox1.Text=="")
            {
                MessageBox.Show("Please Enter The Empolyee Number Empolyee Number And Date");
            }
            else if (File.Exists(@"D:\salary\" + richTextBox1.Text + ".txt"))
            {
                File.Delete(@"D:\salary\" + richTextBox1.Text + ".txt");
            }
            else 
            {
                MessageBox.Show("File Not Found");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form12 obj = new Form12();
            obj.Show();
            this.Hide();
        }
    }
}