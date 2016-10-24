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
    class Class11
    {
        public static string a, b, c, d, e, f, g, h, i, j, k, l;
        public string x, y = null;
        public void hum()
        {
            x = @"D:\customer\";
            Directory.CreateDirectory(x);
            
        }
        public void geo()
        {
            y = @"D:\Customer\" + a + ".txt";
            FileStream ft = null;
            if (a != "" && b != "" && c != "" && d != "" && f != "")
            {
                if (!File.Exists(y))
                {
                    using (File.Create(y)) { }
                    using (StreamWriter obj = new StreamWriter(y))
                    {
                        obj.WriteLine(b);
                        obj.WriteLine(c);
                        obj.WriteLine(d);
                        obj.WriteLine(e);
                        obj.WriteLine(f);
                        obj.WriteLine(g);
                        obj.WriteLine(h);
                        obj.WriteLine(i);
                    }
                }
                else if (File.Exists(y))
                {
                    MessageBox.Show("This Name File ALready Exists");
                }
            }
            else
            {
                MessageBox.Show("INSERT THE COMPLETE INFORMATION");
            }
    
        }
    }
}
