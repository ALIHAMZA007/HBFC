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
    class Class7
    {
        public string hamza = null;
        public static string a = null;
        public void delete()
        {
            hamza = @"D:\Empolyee\" + a + ".txt";
            FileStream jk = null;
            if (a == "")
            {
                MessageBox.Show("ENter The EMPOLYEE NAME");  
            }
            else    if (File.Exists(hamza))
            {
                File.Delete(hamza);
            }
            else
            {
                MessageBox.Show("File not Exists");
            }
            
            
        }
       
    }
}
