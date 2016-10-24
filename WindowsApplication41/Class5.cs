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
    class Class5
    {
        public static string a, b, c, d, e, f, g, h, i, j, k, l, m, n, p, q, r, s, t, u, v, w, x, ab, ac, ad, ae, af, o;
        public string z = null;
        public string y = null;
        
        public void create()
        {

            y = @"D:\Empolyee\";
            Directory.CreateDirectory(y);

        }
        public void save()
        {
            z = y+ a + ".txt";
            FileStream fr = null;
            if (a != "" && b != "" && c != "" && d != "" && e != "" && f != "" && g != "" && h != "" && i != "" && j != "" && k != "" && l != "" && m != "")
            {
                if (!File.Exists(z))
                {
                    using (File.Create(z)) { }
                    using (StreamWriter obj = new StreamWriter(z))
                    {
                        obj.WriteLine(b);
                        obj.WriteLine(c);
                        obj.WriteLine(d);
                        obj.WriteLine(e);
                        obj.WriteLine(f);
                        obj.WriteLine(g);
                        obj.WriteLine(h);
                        obj.WriteLine(i);
                        obj.WriteLine(j);
                        obj.WriteLine(k);
                        obj.WriteLine(l);
                        obj.WriteLine(m);

                    }

                }
                else if (File.Exists(z))
                {
                    MessageBox.Show("File Already Exists");
                }

            }
            else
            {
                MessageBox.Show("Insert the data Completely");

            }
        
        
        
            
        
        }

    }
   
        
    
    
}
