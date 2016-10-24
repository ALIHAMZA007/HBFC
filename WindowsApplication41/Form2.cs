using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication41
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Class1.c;
            Class1 r = new Class1();
            r.hyderabad();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Class1.d;
            Class1 r = new Class1();
            r.Karachi();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Class1.a;
            Class1 r = new Class1();
            r.gujrat();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Class1.b;
            Class1 r = new Class1();
            r.sargodha();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Class1.e;
            Class1 r = new Class1();
            r.Larkana();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Class1.f;
            Class1 r = new Class1();
            r.Sukkur();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Class1.g;
            Class1 r = new Class1();
            r.Jacobabad();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            richTextBox1.Text = Class1.h;

            Class1 r = new Class1();
            r.Quetta();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Class1.i;
            Class1 r = new Class1();
            r.Gawadar();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Class1.j;
            Class1 r = new Class1();
            r.GilGit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Class1.k;
            Class1 r = new Class1();
            r.Swat();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Class1.l;
            Class1 r = new Class1();
            r.Mardan();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Class1.m;
            Class1 r = new Class1();
            r.peshawer();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Class1.n;
            Class1 r = new Class1();
            r.Islamabad();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Class1.o;
            Class1 r = new Class1();
            r.lahore();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Class1.p;
            Class1 r = new Class1();
            r.Sialkot();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Class1.q;
            Class1 r = new Class1();
            r.Gujrunwala();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Class1.r;
            Class1 r = new Class1();
            r.Faisalabad();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Class1.v;
            Class1 r = new Class1();
            r.Muree();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Class1.w;
            Class1 r = new Class1();
            r.Rawalpindi();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

    }
}