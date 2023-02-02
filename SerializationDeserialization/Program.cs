using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;

//using System.IO;
//using System.Text; 

[Serializable]
public class Student
{
    public int Id;
    [NonSerialized]
    public string Name;
    private int Marks;
    private int Class;

    public Student() { }
    public Student(int id, string name, int marks, int Class)
    {
        this.Id = id;
        this.Name = name;
        this.Marks = marks;
        this.Class = Class;


    }
    public int GetMarks
    {
        get { return this.Marks; }
    }
    public int GetClass
    {
        get { return this.Class; }
    }


}

public class Mainclass
{
    public static void Main()
    {
        Student s1 = new Student(101, "Aa", 70, 12);
        Student s2 = new Student(102, "Bb", 71, 13);
        Student s3 = new Student(101, "Cc", 72, 8);
        Student s4 = new Student(101, "Dd", 73, 9);
        List<Student> stulist = new List<Student>() { s1, s2, s3, s4 };


        BinaryFormatter binformatter = new BinaryFormatter();
        FileStream fs = new FileStream(@"F:\\Student.txt", FileMode.OpenOrCreate, FileAccess.Write);
        foreach (Student stu in stulist)
        {
            binformatter.Serialize(fs, s1);
        }
        fs.Close();
        Console.WriteLine("File Created");

    }
}


