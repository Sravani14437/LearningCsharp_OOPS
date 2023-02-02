using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateRealScenario
{
    public class Mainclass
    {
        public static void Main()
        {
            object[] data = new object[]
            {
            new UserProfile("01Name",23,7,11.5),
            new UserProfile("02Name", 24, 8, 12.5),
            new UserProfile("03Name", 25, 9, 13.5),
            new UserProfile("04Name", 26, 10, 14.5),

            };
            CompareFn fnn = new CompareFn(UserProfile.CompareByName);
            Console.WriteLine("b4 sorting.............");
            PrintData(data);
            Utilities.Sort(data, fnn);
            Console.WriteLine("after sorting (by name).......");
            PrintData(data);




        }
        public static void PrintData(object[] obj)
        {
            foreach (UserProfile up in obj)
            {

                Console.WriteLine("{0}\t{1}\t{2}\t{3}", up.Name, up.Age, up.Salary, up.Experience);
            }
        }
    }
}


    



