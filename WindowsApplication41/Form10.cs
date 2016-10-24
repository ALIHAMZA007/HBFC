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
    public partial class Form10 : Form
    {
        string  kam =null;
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class6.a = textBox1.Text;
            textBox2.Text = Class6.b;
            comboBox1.Text = Class6.c;
            textBox3.Text = Class6.d;
            textBox4.Text = Class6.e;
            textBox5.Text = Class6.f;
            textBox6.Text = Class6.g;
            textBox7.Text = Class6.h;
            textBox8.Text = Class6.i;
            textBox9.Text = Class6.j;
            textBox10.Text = Class6.k;
            textBox11.Text = Class6.l;
            textBox12.Text = Class6.m;
           // textBox13.Text = Class6.n;
            //textBox14.Text = Class6.o;
            //textBox15.Text = Class6.p;
            Class6 obj = new Class6();
            obj.search();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class7.a = textBox1.Text;
            Class7 obj = new Class7();
            obj.delete();
            
            
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 obj = new Form8();
            obj.Show();
            this.Hide();
        }
    }
}