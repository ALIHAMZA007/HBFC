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
    class Class10
    {
        public static string ab, ac, ad, ae, af, ag, ah, ai, aj, ak;
        
        public void search()
        { 
        
        FileStream fs = null;
                if (ab == "")
            {
                MessageBox.Show("Please Enter Empolyee Name,Empolyee number And Date");
        
        
            }
            else if (File.Exists(@"D:\salary\"+ab+".txt"))
            {
                using (StreamReader obj = new StreamReader(@"d:\salary\" + ab + ".txt"))
                {
                    ac = obj.ReadLine();
                    ad = obj.ReadLine();
                    ae = obj.ReadLine();
                    af= obj.ReadLine();
                    ag = obj.ReadLine();
                }

            }
            else
            {
                MessageBox.Show("File not Exists");
            }
          
        }
       
        
        
    }
}
