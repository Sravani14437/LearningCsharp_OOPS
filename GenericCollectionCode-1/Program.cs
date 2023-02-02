using System.Collections;


public class Employee
{
    private string _empname;
    private static int n = 901;
    private int _empid;

    public Employee(string empname)
    {
        this._empname = empname;
        this._empid = n++;


    }
    public int EmployeeId { get { return this._empid; } }

    public override string ToString()
    {
        return string.Format("Employee Details : \n\nEmployee Name : {0} \n Employee Id : {1}  ", this._empname, this._empid);
    }
}


public class MainClass
{
    static char choice = 'y';
    static string Name = "sravani";
    static int count = 0;
    static int id = 101;
    public static void Main(string[] args)
    {
        Employee[] earr = new Employee[5];
        //do
        //{
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter employee {0} Name", i);
            Name = Console.ReadLine();
            earr[count++] = new Employee(Name);
        }
        //    Console.WriteLine("Do you want to continue (Y|N): ");
        //    choice = char.Parse(Console.ReadLine());
        //} while (choice == 'Y' || choice == 'y');

        Console.WriteLine("-------------------List-----------------------");
        List<Employee> elist = new List<Employee>();
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter employee {0} Name", i);
            Name = Console.ReadLine();
            elist.Add(new Employee(Name));
        }

        IEnumerable Myenu = elist;
        IEnumerator Myenumerator = Myenu.GetEnumerator();

        while (Myenumerator.MoveNext())
        {
            Console.WriteLine(Myenumerator.Current.ToString());
        }
        Console.WriteLine("-------------------ArrayList-----------------------");
        ArrayList earrlist = new ArrayList();
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter employee {0} Name", i);
            Name = Console.ReadLine();
            earrlist.Add(new Employee(Name));
        }
        Console.WriteLine("-------------------SortedList-----------------------");
        SortedList esl = new SortedList();
        id = 101;
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter employee  Name", i);
            Name = Console.ReadLine();
            esl.Add(id++, new Employee(Name));
        }

        Console.WriteLine("------------------Hashtable-List-----------------------");
        //Hashtable ehashtable = new Hashtable();
        //id = 101;
        //for (int i = 0; i < 5; i++)
        //{
        //    Console.WriteLine("Enter employee {0} Name", i);
        //    Name = Console.ReadLine();

        //    esl.Add(id++, new Employee(Name));
        //}

        Console.WriteLine("-------------------Printing-----------------------");

        IEnumerable enu = elist;
        IEnumerator enumerator = enu.GetEnumerator();

        while (enumerator.MoveNext())
        {
            Console.WriteLine(enumerator.Current);
        }

        Console.WriteLine("-----------------------------------------");

        enumerator.Reset();




        Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++");
        IEnumerable<Employee> ienum = (IEnumerable<Employee>)elist;
        foreach (Employee i in ienum)
        {
            Console.WriteLine(i.ToString());
        }

    }

}

