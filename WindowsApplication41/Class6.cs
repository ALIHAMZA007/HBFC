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
    class Class6
    {
        public static string a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p;
        public void search()
        {
            FileStream uy = null;
            if (a == "")
            {
                MessageBox.Show("Enter The Empolyee Number");
            }
            else if (File.Exists(@"D:\Empolyee\" + a + ".txt"))
            {
                using (StreamReader obj = new StreamReader(@"D:\Empolyee\" + a + ".txt"))
                {
                    b = obj.ReadLine();
                    c = obj.ReadLine();
                    d = obj.ReadLine();
                    e = obj.ReadLine();
                    f = obj.ReadLine();
                    g = obj.ReadLine();
                    h = obj.ReadLine();
                    i = obj.ReadLine();
                    j = obj.ReadLine();
                    k = obj.ReadLine();
                    l = obj.ReadLine();
                    m = obj.ReadLine();
                   // n = obj.ReadLine();

                }
            }
            else 
            {
                MessageBox.Show("File not found");
            }
        
        
        }
        
      }
}
