using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableSortingExample
{
    public class Utilities
    {
        public static void Sort<T>(T[] data) where T : IComparable
        {
            for (int i = 0; i < data.Length - 1; i++)
            {
                for (int j = i + 1; j < data.Length; j++)
                {
                    if ((data[i].CompareTo(data[j])) > 0)
                    {
                        T temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            }
        }
    }
    public struct Student : IComparable
    {
        private int _marks;
        public Student(int marks)
        {
            this._marks = marks;

        }
        public int CompareTo(object s)
        {
            return this._marks.CompareTo(((Student)s).Marks);
        }
        public int Marks
        {
            get { return this._marks; }
        }

    }
}
