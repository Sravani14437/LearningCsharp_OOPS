

using System;
using System.Collections.Generic;
using System.Linq;

public class Employee : IComparable<Employee>
{
    private int Empid { get; set; }
    private string EmpName { get; set; }
    private double EmpSalary { get; set; }

    public int CompareTo(Employee otherEmp)
    {
        if (this.EmpSalary > otherEmp.EmpSalary) { return 1; }
        else if (this.EmpSalary < otherEmp.EmpSalary) { return -1; }
        else { return 0; }
    }

    public override string ToString()
    {
        return String.Format(this.Empid + " " + this.EmpName + " " + this.EmpSalary);
    }


    public static void Main(string[] args)
    {
        List<Employee> emp = new List<Employee>()
            {

                    new Employee{Empid=101,EmpName="Cc",EmpSalary=7000},
                    new Employee{Empid=102,EmpName="Bb",EmpSalary=20000},
                   new Employee{ Empid=103,EmpName="Dd",EmpSalary=35000},
                    new Employee{Empid=104,EmpName="Aa",EmpSalary=6000},
                    new Employee{Empid=105,EmpName="Ee",EmpSalary=5000},



               };
        var empList = emp;
        // IEnumerable<Employee> result =emp.Where(x=>x.name[0]=='S');
        //  foreach(Employee e in result){


        Console.WriteLine(" ************ All Employee Details ************ ");
        IEnumerable<Employee> ienum = (IEnumerable<Employee>)empList;
        foreach (Employee i in ienum)
        {
            Console.WriteLine(i.ToString());
        }

        Console.WriteLine("Using Lambda = Employee Details whose salary is less than 10000");

        //   var lesserlist = emp.Where(em => em.EmpSalary < 10000);
        //   foreach(Employee i in lesserlist)
        //   {
        //       Console.WriteLine(i.ToString());
        //   }

        foreach (var sl in empList.Where(e => e.EmpSalary < 10000))
        {
            Console.WriteLine(sl.ToString());
        }



        Console.WriteLine(" General - Sort all employees based on their salary and Print all employees details after sorting");
        empList.Sort();
        IEnumerable<Employee> ienumsorted = (IEnumerable<Employee>)empList;
        foreach (Employee i in ienumsorted)
        {
            Console.WriteLine(i.ToString());
        }
        Console.WriteLine(" Using Lambda  =  Sort all employees based on their salary and Print all employees details after sorting");

        //      var sortedlist = emp.OrderBy(e => e.EmpSalary );
        //     // Display the sorted result

        // foreach (var semp in sortedlist)
        // {
        //       Console.WriteLine(semp.ToString());
        // }

        foreach (var sl in empList.OrderBy(e => e.EmpSalary))
        {
            Console.WriteLine(sl.ToString());
        }




        Console.WriteLine("Using Lambda Remove all employees whose salary is more than 30000 and print all employees present in list");


        empList.RemoveAll(empG => empG.EmpSalary > 30000);
        // 		for(int i=0;i<5;i++)
        //         {   if(empList[i].EmpSalary>30000)
        //             {
        //             empList.Remove(empList[i]);
        //             }
        //         }
        Console.WriteLine(" --------");
        IEnumerable<Employee> ienumremove = (IEnumerable<Employee>)empList;
        foreach (Employee i in ienumremove)
        {
            Console.WriteLine(i.ToString());
        }




    }
}