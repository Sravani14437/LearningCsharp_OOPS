using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileStreamRead
{
     class Mainclass
    {
        static void Main()
        {
            //creating an object of the filestream class
            FileStream fs = new FileStream(@"f:\abc.txt", FileMode.Open);
            //creating an object of streamReader class
            StreamReader sr = new StreamReader(fs);
            //Reading data from the file
            String str = sr.ReadToEnd();
            Console.WriteLine("Text from the file is as follows:");
            Console.WriteLine(str);
            sr.Close();
            fs.Close();

        }
    }
}
