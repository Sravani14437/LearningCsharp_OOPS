using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Initializer
{
    
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
    class Mainclass
    {
        static void Main()
        {
            List<Person> PersonList = new List<Person>
            {
                new Person{Name="Sravani"},//object initializer
                new Person{Name="Srinu",Age=30}
            };//collection initializer
            foreach(Person p in PersonList)
            {
                Console.WriteLine("Name={0} Age{1}", p.Name, p.Age);
            }
        }
    }
}
