//****************************************************************** 









using System;

using System.Runtime.Serialization.Formatters.Binary;

using System.IO;

using System.Xml.Serialization;

using System.Collections;

using System.Collections.Generic;



public class MarksNegativeException : Exception

{

    // Constructor 

    public MarksNegativeException()

    {

        Console.Write("MarksNegativeException Exception has occurred : ");

    }

}

//******************************************************** 

public class MarksOverException : Exception

{

    // Constructor 

    public MarksOverException()

    {

        Console.Write("MarksOverException has occurred : ");

    }

}

//*************************************************** 





//********************************************** 



[Serializable]

public partial class Student

{

    private static int id = 101;

    public readonly int Id;

    public string Name;

    [NonSerialized]

    private int Class;

    private int Marks;





    public int GetClass

    {

        get { return this.Class; }

    }

    public int GetMarks

    {

        get { return this.Marks; }

    }





}

//************************************************************* 

public partial class Student

{

    public string PrintMarkSheet()

    {

        return String.Format("Id :{0}\n Name :{1}\nClass:{2}\nMarks :{3}", this.Id, this.Name, this.Class, this.Marks);

    }



}

//********************************************************************* 

public partial class Student

{

    public Student(string name, int marks, int cclass)

    {

        //this.Name = name; 

        //this.Class = cclass; 

        //this.Marks = marks; 

        //this.Id = id++; 

        try

        {

            if (marks < 0)

            {

                throw new MarksNegativeException();

            }

            else if (marks > 100)

            {

                throw new MarksOverException();

            }

            else

            {

                this.Name = name;

                this.Marks = marks;

                this.Class = cclass;

                this.Id = id++;

            }

        }

        catch (Exception e)

        {

            Console.Write(e.Message);

        }



    }





}







public class MainClass

{

    static int count = 0;

    static byte option;

    static List<Student> sarr = new List<Student>();





    public static void BinarySerialize()

    {

        BinaryFormatter binformatter = new BinaryFormatter();



        FileStream fs = new FileStream(@"C:\\Users\\M1082488\\Desktop\\.Net Programs\\StudentC.txt", FileMode.OpenOrCreate, FileAccess.Write);



        foreach (Student s1 in sarr)

        {

            binformatter.Serialize(fs, s1);

        }

        fs.Close();

        Console.WriteLine("File Created");

    }



    public static void BinaryDeSerialize()

    {

        List<Student> sarrD2 = new List<Student>();

        BinaryFormatter binformatter = new BinaryFormatter();



        FileStream fs = new FileStream(@"C:\\Users\\M1082488\\Desktop\\.Net Programs\\StudentC.txt", FileMode.Open, FileAccess.Read);



        sarrD2.Add((Student)binformatter.Deserialize(fs));

        //list  

        //sarrD2.Add(new Student(name, marks,cclass)); 

        //   foreach(Student s1 in lst) 

        //   { 

        //     binformatter.Serialize(fs,s1); 

        //   } 

        foreach (Student s2 in sarrD2)

        {

            // sarr[i].PrintMarkSheet(); 

            Console.WriteLine(s2.PrintMarkSheet());

        }

        fs.Close();

        Console.WriteLine("File Deserialized");

    }



    public static void XmlSerialize()

    {

        XmlSerializer xs = new XmlSerializer(typeof(Student));





        FileStream fs = new FileStream(@"C:\\Users\\M1082488\\Desktop\\.Net Programs\\StudentC.txt", FileMode.Create, FileAccess.Write);



        foreach (Student s1 in sarr)

        {

            xs.Serialize(fs, s1);

        }

        fs.Close();

        Console.WriteLine("File Created");

    }

    public static void XmlDeSerialize()

    {

        List<Student> sarrD2 = new List<Student>();

        XmlSerializer xs = new XmlSerializer(typeof(Student));





        FileStream fs = new FileStream(@"C:\\Users\\M1082488\\Desktop\\.Net Programs\\StudentC.txt", FileMode.Open, FileAccess.Read);



        sarrD2.Add((Student)xs.Deserialize(fs));

        //list  

        //sarrD2.Add(new Student(name, marks,cclass)); 

        //   foreach(Student s1 in lst) 

        //   { 

        //     binformatter.Serialize(fs,s1); 

        //   } 

        foreach (Student s2 in sarrD2)

        {

            // sarr[i].PrintMarkSheet(); 

            Console.WriteLine(s2.PrintMarkSheet());

        }

        fs.Close();

        Console.WriteLine("File Deserialized");

    }



    public static void Main()

    {

        char choice = 'y';

        // Student s1 = new Student("sony", 12, 89); 

        //  Console.WriteLine(s1.PrintMarkSheet()); 







        //-------------------------------- 







        Console.WriteLine("Enter name");







        do

        {

            Console.WriteLine("Which service would you like prefer\n1. Add Student\n2. Print Marksheet of a Student \n3. Print All student Marksheets\n4.Binary Serialize Student List \n 5.Binary DeSerialize Student List \n 6. XML Serialize Student List \n 7. XML DeSerialize Student List\n");

            Console.WriteLine("Enter your choice");







            option = byte.Parse(Console.ReadLine());







            switch (option)

            {



                case 1:

                    Console.WriteLine("Name:");



                    string name = Console.ReadLine();

                    Console.WriteLine("Marks:");

                    int marks = int.Parse(Console.ReadLine());

                    Console.WriteLine("Class:");

                    int cclass = int.Parse(Console.ReadLine());



                    sarr.Add(new Student(name, marks, cclass));

                    count++;

                    Console.WriteLine("Details ADDED , and ID is : {0}", sarr[count - 1].Id);









                    break;



                case 2:

                    Console.WriteLine("Enter your roll Number :");

                    int Roll = int.Parse(Console.ReadLine());

                    for (int i = 0; i < count; i++)

                    {



                        if (sarr[i].Id == Roll)

                        {

                            Console.WriteLine(sarr[i].PrintMarkSheet());



                        }

                    }

                    break;

                case 3:

                    Console.WriteLine(count - 1);



                    for (int i = 0; i < count; i++)

                    {

                        // sarr[i].PrintMarkSheet(); 

                        Console.WriteLine(sarr[i].PrintMarkSheet());

                    }

                    break;



                case 4:

                    BinarySerialize();

                    break;

                case 5:

                    BinaryDeSerialize();

                    break;

                case 6:

                    XmlSerialize();

                    break;

                case 7:

                    XmlDeSerialize();

                    break;





            }

            Console.WriteLine("Do you want to continue (Y|N): ");

            choice = char.Parse(Console.ReadLine());

        } while (choice == 'Y' || choice == 'y');

    }



}

//****************************************************************** 
