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
    class Class4
    {
        public static string a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z;

        public void retrieve()
        {

            FileStream tr = null;
            if(a =="" || b=="")
            {
                MessageBox.Show("Please Enter The Password And UserName");
            }
            else if(File.Exists(@"D:\HBFCL\" + a + ".txt") && (File.Exists(@"D:\HBFCL\" + b + ".txt")))
            {
                using (StreamReader obj = new StreamReader(@"D:\HBFCL\" + a + ".txt"))
                {
                    c = obj.ReadLine();
                    d = obj.ReadLine();
                    e = obj.ReadLine();
                    f = obj.ReadLine();
                    g = obj.ReadLine();
                    h= obj.ReadLine();
                    i= obj.ReadLine();
                    j = obj.ReadLine();
                    k= obj.ReadLine();
                    l = obj.ReadLine();
                    m = obj.ReadLine();
                    n = obj.ReadLine();
                    o = obj.ReadLine();
                    p = obj.ReadLine();
                    q = obj.ReadLine();
                    r = obj.ReadLine();
                    s = obj.ReadLine();
                    t = obj.ReadLine();
                    u= obj.ReadLine();
                    v = obj.ReadLine();
                    w = obj.ReadLine();
                    x = obj.ReadLine();
                    y = obj.ReadLine();
                    z = obj.ReadLine();
                } 
            }
            else 
            {

                MessageBox.Show("File Not Exists");
            }



        }
    }
}
