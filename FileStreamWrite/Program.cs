using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileStreamWrite
{
    class Mainclass
    {
        static void Main()
        {
            //creating an object of the filestream class
            FileStream fs = new FileStream(@"C:\abc.txt", FileMode.OpenOrCreate);
            //creating an object of streamWriter class
            StreamWriter sw = new StreamWriter(fs);
            //Writing to the  file
            
            sw.WriteLine("My  name is Sravani");
            
            sw.Close();
            fs.Close();

        }
    }
}
