using System.Collections.Generic;
using System.Linq;
using System;


namespace QueryKeyWords
{
    class MainClass
    {
        public class Department
        {
            public int DID { get; set; }
            public string Name { get; set; }
        }
        public class Employee
        {
            public int EmpID { get; set; }
            public string Name { get; set; }
            public int DeptID { get; set; }
        }
        static void InnerJoin()
        {
            List<Department> Departments = new List<Department>
 {
 new Department{DID=1, Name="sales"},
 new Department{DID=2,Name="Makerting"},
 new Department{DID=3,Name="Software"}
 };
            List<Employee> Employees = new List<Employee>
 {
 new Employee {EmpID=1, Name="Mony",DeptID=1},
 new Employee {EmpID=2, Name="Tom",DeptID=2},
 new Employee {EmpID=3, Name="Sony",DeptID=2},
 new Employee {EmpID=4, Name="John",DeptID=2},
 new Employee {EmpID=5, Name="Rohan",DeptID=3},
 new Employee {EmpID=6, Name="Rohit",DeptID=1}
 };
            var innerJoinQuery = from emp in Employees
                                 join dept in Departments on emp.DeptID equals dept.DID
                                 select new { EmployeeName = emp.Name, DeptName = dept.Name };
            foreach (var emp in innerJoinQuery)
            {
                Console.Write(emp.EmployeeName + "\t");
                Console.WriteLine(emp.DeptName);
            }
        }
        static void Main()
        {
            InnerJoin();
        }
    }
    static void SimpleSelection()
    {
        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        var lowNums = from num in numbers
                      where num < 5 && num % 2 == 0
                      select num;
        foreach (int i in lowNums)
        {
            Console.WriteLine(i + "");
        }
        Console.WriteLine("\n Sum: " + lowNums.Sum());
    }
    
    static void UsingInto()
    {
        //It can be used to create a temporary identifier to store the result of a group.
        //join or select clause into a new identifier
        //create a data source
        string[] words = { "apples", "anjir", "avacado", "blueberries", "oranges", "bananas" };
        //create the query
        var wordGroups1 = from w in words
                          group w by w[0] into fruitGroup
                          where fruitGroup.Count() >= 2
                          select new
                          {
                              FirstLetter = fruitGroup.Key,
                              count = fruitGroup.Count()
                          };
        //Execute the query note that we only iterate over the groups.
        //not the items in each group
        foreach (var item in wordGroups1)
        {
            Console.WriteLine("{0} has {1} elements.", item.FirstLetter, item.count);
        }
        static void GroupBy()
        {
            //The group clause returns a sequence of IGrouping  of (TKey,TElement)) objects that contain zero or more items that match 
            string[] Names = { "Sravani", "Kavya", "Surendra", "Pavani", "Srinu" };
            var NameGropus =
            from name in Names //foreach(string name in Names)
            group name by name[0];
            IEnumerable<object> NameGroups = null;
            //Execute the query
            foreach (var names in NameGroups)
            {
                Console.WriteLine("Names that start with the letter'{0}':", names.Key);
                foreach (string name in NameGroups)
                {
                    Console.WriteLine(name);
                }
            }
        }
        static void crossJoin()
        {
            char[] upperCase = { 'A', 'B', 'C' };
            char[] lowerCase = { 'x', 'y', 'z' };
            var joinQuery1 = from upper in upperCase
                             from lower in lowerCase
                             select new { upper, lower };//Anonymous type created
                                                         //Execute the queries.
            Console.WriteLine("Cross join:");
            foreach (var pair in joinQuery1)
            {
                Console.WriteLine("{0} is matched to {1}", pair.upper, pair.lower);
            }
            var joinQuery2 = from lower in lowerCase
                             where lower != 'x'
                             from upper in upperCase
                             select new { lower, upper };
            Console.WriteLine("Filtered non-equijoin:");
            foreach (var pair in joinQuery2)
            {
                Console.WriteLine("{0} is matched to {1}", pair.lower, pair.upper);
            }
        }
        static void CompoundFrom()
        {
            //use a collection initializer to create the data source.note that
            //each element in the list contains an inner sequence of scores.
            List<Student> students = new List<Student>
 {
 new Student {LastName="Sravani", Scores=new List<int> {89,72,13,60}},
 new Student {LastName="Saikiran", Scores=new List<int> {75,94,91,39}},
 new Student {LastName="Jyothi", Scores=new List<int> {88,94,65,85}},
 new Student {LastName="Venkat", Scores=new List<int> {97,89,85,82}},
 new Student {LastName="Sadvitha", Scores=new List<int> {35,72,91,70}},
 };
            //select all the students and that scores greater than 90
            //use a compound from to access the inner sequence within an element.
            //note the similarity toa nested foreach statement.
            var scoreQuery = from student in students
                             from score in student.Scores
                             where score > 90
                             select new { Last = student.LastName, score };
            //Execute the queries.
            Console.WriteLine("scoreQuery:");
            foreach (var stud in scoreQuery)
            {
                Console.WriteLine("{0} Score :{1}", stud.Last, stud.score);
            }
        }
    }
}

