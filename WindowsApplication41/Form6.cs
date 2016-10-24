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
    public partial class Form6 : Form
    {
        string ali = null;
        string hamza = null;
        public Form6()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*ali = @"C:\HBFCL\" + textBox1.Text + ".txt";
            hamza = @"C:\HBFCL\" + textBox2.Text + ".txt";
            FileStream tr = null;
            if(textBox2.Text =="" || textBox1.Text=="")
            {
                MessageBox.Show("Please Enter The Password And UserName");
            }
            else if(File.Exists(ali) && (File.Exists(hamza)))
            {
                using (StreamReader obj = new StreamReader(ali))
                {
                    textBox3.Text = obj.ReadLine();
                    textBox4.Text = obj.ReadLine();
                    textBox5.Text = obj.ReadLine();
                    textBox6.Text = obj.ReadLine();
                    textBox7.Text = obj.ReadLine();
                    textBox8.Text = obj.ReadLine();
                    textBox9.Text = obj.ReadLine();
                    textBox10.Text = obj.ReadLine();
                    textBox11.Text = obj.ReadLine();
                    textBox12.Text = obj.ReadLine();
                    textBox13.Text = obj.ReadLine();
                    textBox14.Text = obj.ReadLine();
                    textBox16.Text = obj.ReadLine();
                    textBox17.Text = obj.ReadLine();
                    textBox18.Text = obj.ReadLine();
                    textBox19.Text = obj.ReadLine();
                    textBox20.Text = obj.ReadLine();
                    textBox21.Text = obj.ReadLine();
                    textBox22.Text = obj.ReadLine();
                    textBox23.Text = obj.ReadLine();
                    textBox24.Text = obj.ReadLine();
                    textBox25.Text = obj.ReadLine();
                    textBox26.Text = obj.ReadLine();
                } 
            }
            else 
            {

                MessageBox.Show("File Not Exists");
            }*/





            Class4.a = textBox1.Text;
            Class4.b = textBox2.Text;
            textBox3.Text = Class4.c;
            textBox4.Text = Class4.d;
            textBox5.Text = Class4.e;
            textBox6.Text = Class4.f;
            textBox7.Text = Class4.g;
            textBox8.Text = Class4.h;
            textBox9.Text = Class4.i;
            textBox10.Text = Class4.j;
            textBox11.Text = Class4.k;
            textBox12.Text = Class4.l;
            textBox13.Text = Class4.m;
            textBox14.Text = Class4.n;
            textBox15.Text = Class4.o;
            textBox16.Text = Class4.p;
            textBox17.Text = Class4.q;
            textBox18.Text = Class4.r;
            textBox19.Text = Class4.s;
            textBox20.Text = Class4.t;
            textBox21.Text = Class4.u;
            textBox22.Text = Class4.v;
            textBox23.Text = Class4.w;
            textBox24.Text = Class4.x;
            textBox25.Text = Class4.y;
            textBox26.Text = Class4.z;
            Class4 obj = new Class4();
            obj.retrieve();
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }
    }
}