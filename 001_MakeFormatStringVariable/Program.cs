using System;

namespace _001_MakeFormatStringVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello {0:F5}", 0);

            // Variante 1
            string output1 = "Hello {0:F5}";
            output1 = output1.Replace("{0:F5}", "{0:F10}");
            Console.WriteLine(output1, 1);

            // Variante 2
            int numberOfDigits = 20;
            string output2 = "Hello {0:F" + numberOfDigits + "}";
            Console.WriteLine(output2, 2);
        }
    }
}