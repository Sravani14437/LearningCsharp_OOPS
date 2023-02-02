
using System;
using System.Collections;
using System.Collections.Generic;

public class Employee
{
    private string _empname;
    private static int n = 901;
    public readonly int _empid;



    public Employee(string empname)
    {
        this._empname = empname;
        this._empid = n++;

    }

    public override string ToString()
    {
        return string.Format("Employee Details : \n\nEmployee Name : {0} \nEmployee Id : {1}  ", this._empname, this._empid);
    }
}


public class MainClass
{

    public static void Main(string[] args)
    {
        Employee[] earr = new Employee[5]{
            new Employee("C"),
            new Employee("D"),
            new Employee("B"),
            new Employee("E"),
            new Employee("A")
        };
        Console.WriteLine("**************************Array********");
        foreach (Employee e in earr)
        {
            Console.WriteLine(e.ToString());
        }
        //*******************************************************

        //NonGeneric Lists :ArrayList , SortedList

        ArrayList al = new ArrayList()
    {
              new Employee("C"),
            new Employee("D"),
            new Employee("B"),
            new Employee("E"),
            new Employee("A")

    };
        Console.WriteLine("*******************************ArrayList********");
        IEnumerable ienumAL = (IEnumerable)al;
        foreach (Employee i in ienumAL)
        {
            Console.WriteLine(i.ToString());
        }
        //&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
        Employee s1 = new Employee("B");

        Employee s2 = new Employee("C");
        Employee s3 = new Employee("A");
        SortedList sl = new SortedList() {

                                  {s3._empid, s3 },
                                  { s1._empid, s1 },
                                  { s2._empid, s2 }

                                     };

        Console.WriteLine("**************************SortedList********");
        IEnumerable ienumSL = (IEnumerable)sl;
        foreach (DictionaryEntry i in ienumSL)
        {
            Console.WriteLine(i.Key + " = " + (i.Value).ToString());
        }

        // Generic List , Hashtable(Dictionary)

        List<Employee> emplist = new List<Employee>()
        {
            new Employee("C"),
            new Employee("D"),
            new Employee("B"),
            new Employee("E"),
            new Employee("A")
        };

        Console.WriteLine("********************************** Generic List ********");
        // IEnumerable Myenu = emplist;
        IEnumerator Myenumerator = emplist.GetEnumerator();



        while (Myenumerator.MoveNext())
        {
            Console.WriteLine(Myenumerator.Current);
        }

        // generic Hashtable = Dictionary
        Employee s4 = new Employee("C");

        Employee s5 = new Employee("A");
        Employee s6 = new Employee("B");
        Dictionary<int, Employee> empD = new Dictionary<int, Employee>()
       {            { s4._empid, s4 },
                    { s5._empid, s5 },
                    { s6._empid, s6 }

        };

        Console.WriteLine("********************************** Dictionary List = Generic Hashtable ********");

        IEnumerator MyenumeratorD = empD.GetEnumerator();



        while (MyenumeratorD.MoveNext())
        {
            Console.WriteLine(MyenumeratorD.Current);
        }

    }
}