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
    class Class3
    {
        public static string a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, ab, ac, ad, ae, af, ah, ai, aj, ak, al, am, an, ao, ap, aq, ar, at, au, av, aw, ax, ay, az, tip, hum, no;
        public string bol;
        public void sarmad()
        {
            bol = @"D:\HBFCL\" + a + ".txt";
            FileStream tr = null;
            if(a!="" && b!="" && c!="" && d!=""  && e!=""  && f!="" && g!="" && h!="" && i!="" && j!="" && k!="" && l!="" && m!="" && n!="" && o!="" && p!="" && q!="" && r!="" && s!="" && t!="" && u!="" && v!="" && w!="" && x!="" && ab!="" && ac!="" && ad!="" && ae!="" && af!="" && ah!="" && ai!="" && aj!="" && ak!="" &&  al!="" && am!="" && an!="" && ao!="" && ap!="" && aq!= "" && tip!="" )
            {
            if (!File.Exists(bol))
            {
                using (File.Create(bol)) { }
                using (StreamWriter obj = new StreamWriter(bol))
                {
                    obj.WriteLine(x);
                    obj.WriteLine(p);
                    obj.WriteLine(e);
                    obj.WriteLine(ab);
                    obj.WriteLine(s);
                    obj.WriteLine(c);
                    
                    obj.WriteLine(t);
                    obj.WriteLine(w);
                    obj.WriteLine(b);
                    obj.WriteLine(h);
                    obj.WriteLine(o);
                    obj.WriteLine(ae);
                    obj.WriteLine(q);
                    obj.WriteLine(n);
                    obj.WriteLine(v);
                    obj.WriteLine(f);
                    obj.WriteLine(ac);
                    obj.WriteLine(i);
                    obj.WriteLine(u);
                    obj.WriteLine(l);
                    obj.WriteLine(ad);
                    obj.WriteLine(d);
                    obj.WriteLine(r);
                    obj.WriteLine(no);
                    obj.WriteLine(j);
                    obj.WriteLine(tip);
                    obj.WriteLine(k);
                    obj.WriteLine(g);
                    obj.WriteLine(m);
                    obj.WriteLine(ah);
                    obj.WriteLine(hum);
                    obj.WriteLine(af);
                    obj.WriteLine(y);
                    obj.WriteLine(z);
                    obj.WriteLine(ak);
                    obj.WriteLine(al);
                    obj.WriteLine(aq);
                    obj.WriteLine(am);
                    obj.WriteLine(ap);
                    obj.WriteLine(ao);
                    obj.WriteLine(ai);
                    obj.WriteLine(aj);
                    obj.WriteLine(an);
                    obj.WriteLine(h);
                    
                    
                   
                    
                    
                    
                   
                   
                    
                    
                }
                MessageBox.Show("You Have Completed The Application");
                MessageBox.Show("LOAN WILL BE GIVEN IN ONE WEEK AFTER THE VERIFIACTION OF DOCUMENTS ");
            }
            else if (File.Exists(bol))
            {
                MessageBox.Show("Already exists");
            
            }
            }
            else
            {
            
                MessageBox.Show("Fill The Form Completely");
            }
            
          }
        public void retrieve()
        { }
    }
}
