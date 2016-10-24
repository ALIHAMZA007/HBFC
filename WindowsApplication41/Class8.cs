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
    class Class8
    {
        public static string a;
        public string b = null;
        public void erase()
        { 
            b=@"D:\customer\"+a+".txt";
            FileStream fs=null;
            if (a == "")
            {
                MessageBox.Show("Enter The Customer Name");
            }
            else if (File.Exists(b))
            {
                File.Delete(b);
            }
            else
            {
                MessageBox.Show("File Not Found");
            }

        }
        

    }
}
