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
            Console.WriteLine("Write int type");
            string s = Console.ReadLine();
            int i = int.Parse(s);
            Console.WriteLine(i);
            Console.WriteLine("Write double type");
            string ss = Console.ReadLine();
            double d = double.Parse(ss);
            Console.WriteLine(d);
            Console.WriteLine("Write byte type");
            string sss = Console.ReadLine();
            byte b = byte.Parse(sss);
            Console.WriteLine(b);
            Console.WriteLine("Write short type");
            string ssss = Console.ReadLine();
            short sh = short.Parse(ssss);
            Console.WriteLine(sh);
            Console.WriteLine("Write sbyte type");
            string sssss = Console.ReadLine();
            sbyte sb = sbyte.Parse(sssss);
            Console.WriteLine(sb);
            Console.WriteLine("Write bool type");
            string ssssss = Console.ReadLine();
            bool bol = bool.Parse(ssssss);
            Console.WriteLine(bol);




            Console.WriteLine();





        }

        static void Main(string[] args)
        {
            Task_SORED_6();
            Console.ReadLine();
        }
    }
}
