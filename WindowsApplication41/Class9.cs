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
    class Class9
    {
        public static string a, b, c, d, e, f, g, h;
        public string y, z = null;
        public void make()
        {
            y = @"D:\Salary\";
            Directory.CreateDirectory(y);
        }
        public void save()
        {
            z = @"D:\salary\" + h + a + b + ".txt";
            FileStream fs = null;
            if (a != "" && b != "" && c != "" && d != "" && e != "" && f != "" && h != "")
            {
                if (!File.Exists(z))
                {
                    using (File.Create(z)) { }
                    using (StreamWriter obj = new StreamWriter(z))
                    {
                        obj.WriteLine(c);
                        obj.WriteLine(d);
                        obj.WriteLine(e);
                        obj.WriteLine(f);
                        obj.WriteLine(g);

                    }

                }
                else if (File.Exists(z))
                {
                    MessageBox.Show("File Already Exists");
                }
            }
            else
            {
                MessageBox.Show("Fill The Blank Completely");
            }

        
        }
    }
}
