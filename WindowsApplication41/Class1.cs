
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
    class Class1
    {

        public static string a, w, n;
        public static string b, s, t, u, v;
        public static string c, o, p, q, r;
        public static string d, j, k, l, m;
        public static string e, f, g, h, i;

       // public string a = null;
        
        public void gujrat()
        {
            
            //a = @"D:\Text2.txt";
            if (File.Exists(@"D:/Branches Locator/Gujrat.txt"))
            {
                FileStream fs = null;
                using (TextReader r = new StreamReader(@"D:/Branches Locator/Gujrat.txt"))
                {

                    a= r.ReadToEnd();
                    r.Close();
                }
            }
        }
        public void sargodha()
        {
            if (File.Exists(@"D:\Branches Locator\Sargodha.txt"))
            {
                FileStream fs = null;
                using (TextReader r=new StreamReader(@"D:\Branches Locator\Sargodha.txt"))
                {
                    b=r.ReadToEnd();
                }
            }
        }
        public void hyderabad()
        {
            if (File.Exists(@"D:/Branches Locator/Hyderabad.txt"))
            {
                FileStream fs = null;
                using (TextReader r = new StreamReader(@"D:/Branches Locator/Hyderabad.txt"))
                {
                    c = r.ReadToEnd();
                }
            }
        }
        public void Karachi()
        {
            if (File.Exists(@"D:\Branches Locator\Karachi.txt"))
            {
                FileStream fs = null;
                using (TextReader r = new StreamReader(@"D:\Branches Locator\Karachi.txt"
                    ))
                {
                    d = r.ReadToEnd();
                }
            
            }
        }
        public void Larkana()
        {
            if (File.Exists(@"D:\Branches Locator\Larkana.txt"))
            {
                FileStream fs = null;
                using (TextReader r = new StreamReader(@"D:\Branches Locator\Larkana.txt"))
                    
                {
                    e = r.ReadToEnd();
                }
            }

        }
        public void Sukkur()
        {
            if (File.Exists(@"D:\Branches Locator\Sukkur.txt"))
            {
                FileStream fs = null;
                using (TextReader r = new StreamReader(@"D:\Branches Locator\Sukkur.txt"
                    ))
                {
                    f = r.ReadToEnd();
                }
            }
        }
        public void Jacobabad()
        {
            if (File.Exists(@"D:\Branches Locator\Jacobabad.txt"))
            {
                FileStream fs = null;
                using (TextReader r = new StreamReader(@"D:\Branches Locator\Jacobabad.txt"
                    ))
                {
                    g = r.ReadToEnd();
                }
            }
        }
        public void Quetta()
        {
            if (File.Exists(@"D:\Branches Locator\Quetta.txt"))
            {
                FileStream fs = null;
                using (TextReader r = new StreamReader(@"D:\Branches Locator\Quetta.txt"
                    ))
                {
                    h = r.ReadToEnd();
                }
            }
        }
        public void Gawadar()
        {
            if (File.Exists(@"D:\Branches Locator\Gawadar.txt"))
            {
                FileStream fs = null;
                using (TextReader r = new StreamReader(@"D:\Branches Locator\Gawadar.txt"
                    ))
                {
                    i = r.ReadToEnd();
                }
            }
        }
        public void GilGit()
        {
            if (File.Exists(@"D:\Branches Locator\Gilgit.txt"))
            {
                FileStream fs = null;
                using (TextReader r = new StreamReader(@"D:\Branches Locator\Gilgit.txt"
                    ))
                {
                    j = r.ReadToEnd();
                }
            }

        }
        public void Swat()
        { 
        
       if (File.Exists(@"D:\Branches Locator\Swat.txt"))
            {
                FileStream fs = null;
                using (TextReader r = new StreamReader(@"D:\Branches Locator\Swat.txt"
                    ))
                {
                    k = r.ReadToEnd();
                }
            }
        
        }
        public void Mardan()
        {


            if (File.Exists(@"D:\Branches Locator\Mardan.txt"))
            {
                FileStream fs = null;
                using (TextReader r = new StreamReader(@"D:\Branches Locator\Mardan.txt"
                    ))
                {
                    l= r.ReadToEnd();
                }
            }
        
        
        }
        public void peshawer()
        { 
        
           if (File.Exists(@"D:\Branches Locator\Peshawer.txt"))
            {
                FileStream fs = null;
                using (TextReader r = new StreamReader(@"D:\Branches Locator\Peshawer.txt"
                    ))
                {
                    m= r.ReadToEnd();
                }
            }
        }
        public void Islamabad()
        {

            if (File.Exists(@"D:\Branches Locator\Islamabad.txt"))
            {
                FileStream fs = null;
                using (TextReader r = new StreamReader(@"D:\Branches Locator\Islamabad.txt"
                    ))
                {
                    n = r.ReadToEnd();
                }
            }
        
        }
        public void lahore()
        {

            if (File.Exists(@"D:\Branches Locator\Lahore.txt"))
            {
                FileStream fs = null;
                using (TextReader r = new StreamReader(@"D:\Branches Locator\Lahore.txt"
                    ))
                {
                    o = r.ReadToEnd();
                }
            }
        
        
        
        }
        public void Sialkot()
        {

            if (File.Exists(@"D:\Branches Locator\Sailkot.txt"))
            {
                FileStream fs = null;
                using (TextReader r = new StreamReader(@"D:\Branches Locator\Sailkot.txt"
                    ))
                {
                    p= r.ReadToEnd();
                }
            }
        
        
        }
        public void Gujrunwala()
        {


            if (File.Exists(@"D:\Branches Locator\Gujranwala.txt"))
            {
                FileStream fs = null;
                using (TextReader r = new StreamReader(@"D:\Branches Locator\Gujranwala.txt"
                    ))
                {
                    q = r.ReadToEnd();
                }
            }
        
        }
        public void Faisalabad()
        {


            if (File.Exists(@"D:\Branches Locator\Faisalabad.txt"))
            {
                FileStream fs = null;
                using (TextReader rec = new StreamReader(@"D:\Branches Locator\Faisalabad.txt"
                    ))
                {
                    r = rec.ReadToEnd();
                }
            }
        
        
        }
        public void Mianwali()
        {



            if (File.Exists(@"D:\Branches Locator\Mianwali.txt"))
            {
                FileStream fs = null;
                using (TextReader r = new StreamReader(@"D:\Branches Locator\Mianwali.txt"
                    ))
                {
                    s = r.ReadToEnd();
                }
            }
        
        
        }
        public void Chitral()
        {


            if (File.Exists(@"D:\Branches Locator\Chitral.txt"))
            {
                FileStream fs = null;
                using (TextReader r = new StreamReader(@"D:\Branches Locator\Chitral.txt"
                    ))
                {
                    t= r.ReadToEnd();
                }
            }
        
        
        
        }
        public void Jehlum()
        {

            if (File.Exists(@"D:\Branches Locator\Jehlum.txt"))
            {
                FileStream fs = null;
                using (TextReader r = new StreamReader(@"D:\Branches Locator\Jehlum.txt"
                    ))
                {
                    u = r.ReadToEnd();
                }
            }
        
        
        
        }
        public void Muree()
        {


            if (File.Exists(@"D:\Branches Locator\Muree.txt"))
            {
                FileStream fs = null;
                using (TextReader r = new StreamReader(@"D:\Branches Locator\Muree.txt"
                    ))
                {
                    v = r.ReadToEnd();
                }
            }
        
        
        }
        public void Rawalpindi()
        {




            if (File.Exists(@"D:\Branches Locator\Rawalpindi.txt"))
            {
                FileStream fs = null;
                using (TextReader r = new StreamReader(@"D:\Branches Locator\Rawalpindi.txt"
                    ))
                {
                    w = r.ReadToEnd();
                }
            }
        
        
        }


    }

    }
