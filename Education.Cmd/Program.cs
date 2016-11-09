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

        public static void Task_SORED_5()
        {
            //Дослідити способи читання значення з клавіатури:
            Console.ReadLine();
            Console.ReadKey();
            Console.WriteLine("Type anything");
            string s = Console.ReadLine();
            Console.WriteLine("Your tekst are {0}", s);
            Console.ReadKey();
            Console.WriteLine("you used readkey no paramtrs");
            ConsoleKeyInfo sss = Console.ReadKey(true);
            Console.WriteLine("you used readkey with paramtrs {0}", sss.Modifiers);



        }

        static void Main(string[] args)
        {
            Task_SORED_5();
            Console.ReadLine();
        }
    }
}
