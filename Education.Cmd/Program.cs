using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using Microsoft.SqlServer.Server;

namespace Education.Cmd
{
    class Program
    {
        static int[] primeNumbers = new int[]
        { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37,
            41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };

        public static void Task_SORED_6()
        {
            //Дослідити методи простих типів:
            //T Parse(string value);
            //bool TryParse(string value, out T);
            //Використовуючи навички, здобуті в SORED-5, зчитати значення з клавіатури і перетворити у відповідні типи.
            //Приклад програми - скріншот
            Console.WriteLine("Write ");
            string s = Console.ReadLine();
            int b;
            int.TryParse(s, out b);
            Console.WriteLine(b);
          



            Console.WriteLine();





        }

        static void Main(string[] args)
        {
            Task_SORED_6();
            Console.ReadLine();
        }
    }
}
