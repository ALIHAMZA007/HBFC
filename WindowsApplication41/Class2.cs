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
    class Class2
    {
        public string g = null;
        public string h = null;
        
        public static string rado = null;
        public static string fide = null;

        public void get()
        {
            g = @"D:\HBFCL\";
            Directory.CreateDirectory(g);
                
        }
        public void raffy()
        {
            h = g + rado + ".txt";
            FileStream fs = null;
            if (!File.Exists(h) && (rado != "") && (fide != ""))
            {
                using (File.Create(h)) { }

                MessageBox.Show("Successfully Login");
                Form5 r = new Form5();
                r.Show();




            }
            else if ((rado == "") || (fide == ""))
            {
                MessageBox.Show("Please Enter the username and password");
            }
            else if (File.Exists(h))
            {
                MessageBox.Show("User Name And Password Already Exists Create Another one");
            }
        }
        
    }
}
