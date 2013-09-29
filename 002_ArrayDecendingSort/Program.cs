using System;

namespace _002_ArrayDecendingSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 6, 2, 5 };

            Console.WriteLine("Array:          " + String.Join(", ", array));

            Array.Reverse(array);
            Console.WriteLine("Reverse:        " + String.Join(", ", array));

            Array.Sort(array);
            Array.Reverse(array);
            Console.WriteLine("Decending sort: " + String.Join(", ", array));
        }
    }
}