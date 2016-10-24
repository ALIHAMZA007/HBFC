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
    public partial class Form11 : Form
    {
        string b = null;
        string c = null;
        public Form11()
        {
            c = @"D:\Attendance\";
            Directory.CreateDirectory(c);
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            b = c + textBox1.Text + ".txt";
            FileStream fs = null;
            if (textBox1.Text != "" && richTextBox1.Text != "")
            {
                if (!File.Exists(b))
                {
                    using (File.Create(b)) { }
                    using (StreamWriter obj = new StreamWriter(b))
                    {
                        obj.WriteLine(richTextBox1.Text);
                    }
                }
                else if (File.Exists(b))
                {
                    MessageBox.Show("This name File Already Exist");
                }
            }
            else
            {
                MessageBox.Show("Please Enter The Empolyee Nmae And Date");
            }
           
     


        }

        private void button2_Click(object sender, EventArgs e)
        {
            b = c + textBox1.Text + ".txt";
            FileStream fs = null;
            if (textBox1.Text != "")
            {
                if (File.Exists(b))
                {
                    using (TextReader obj = new StreamReader(b))
                    {
                        richTextBox1.Text = obj.ReadToEnd();
                    }
                }
                else if (!File.Exists(b))
                {
                    MessageBox.Show("File not Found");
                }

            }
            else
            {
                MessageBox.Show("PLEASE ENTER THE DATE ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            b = c + textBox1.Text + ".txt";
            if (textBox1.Text != "")
            {
                if (File.Exists(b))
                {
                    File.Delete(b);
                }
                else if (!File.Exists(b))
                {
                    MessageBox.Show("File Not Found");
                }
            }
            else
            {
                MessageBox.Show("Please Enter The Proper Date");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form8 obj = new Form8();
            obj.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}