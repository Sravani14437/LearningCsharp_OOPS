using System;
using System.Collections;



public class MyMainClass
{

    public static void Swap<T>(ref T a, ref T b) where T : IComparable<T>
    {
        if (a.CompareTo(b) == 0)
        {
            Console.WriteLine("Values  are Equal");
        }
        else
        {
            T temp;
            temp = a;
            a = b;
            b = temp;

        }
    }
    public static void Main()
    {
        int i = 10;
        int j = 20;
        Console.WriteLine("Before Swap i={0},j={1}", i, j);
        Swap<int>(ref i, ref j);
        Console.WriteLine("After Swap i={0},j={1}", i, j);
    }
}
