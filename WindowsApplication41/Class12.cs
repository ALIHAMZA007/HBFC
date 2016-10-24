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
    class Class12
    {
        public static string a, b, c, d, e, f, g, h, i;
        public string z=null;
        public void Search()
        {
            z=@"D:\Customer\"+a+".txt";
            FileStream fr=null;
            if(a=="")
            {
                MessageBox.Show("Please Enter The Customer Name");
            }
            else if(File.Exists(z))
            {
                using(StreamReader obj=new StreamReader(z))
                {
                    b=obj.ReadLine();
                    c=obj.ReadLine();
                    d=obj.ReadLine();
                    e=obj.ReadLine();
                    f=obj.ReadLine();
                    g=obj.ReadLine();
                    h=obj.ReadLine();
                    i=obj.ReadLine();
                }
            }
            else
            {
                MessageBox.Show("File Not Exists");
            }
        }
    }
}
