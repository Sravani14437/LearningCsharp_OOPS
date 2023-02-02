using System;
namespace AverageOfMarks
{
    class Mainclass
    {
        static void Main()
        {
            int marks1, marks2, marks3, total;
            int average;
            console.WriteLine("Enter C# subject marks:");
            marks1 = covert.ToInt32(console.ReadLine());
            console.WriteLine("Enter Asp.net subject marks:");
            marks2 = covert.ToInt32(console.ReadLine());
            console.WriteLine("Enter SqlServer subject marks:");
            marks3 = covert.ToInt32(console.ReadLine());
            total = marks1 + marks2 + marks3;
            average = marks1 + marks2 + marks3 / 3;
            console.WriteLine("Average marks:" + average);
            if (average < 50)
            {
                console.WriteLine("Student is passed");
            }
            else
            {
                console.WriteLine("Student is failed");
            }
        }
    }
