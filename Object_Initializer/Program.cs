using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Initializer
{
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string City;
        public Person()
        {
            Console.WriteLine("Default");
        }
    }
    class Mainclass
    {
        static void Main()
        {
            Person p = new Person { Age = 23, Name = "Sravani", City = "Hyderabad" };//object initializer
            p.Age = 20;p.Name = "Suraj";
            Console.WriteLine("Age={0},Name={1},City={2}", p.Age, p.Name, p.City);
        }
    }
}
