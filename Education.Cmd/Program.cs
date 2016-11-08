using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using Microsoft.SqlServer.Server;

namespace Education.Cmd
{
    class Program
    {
        static int[] primeNumbers = new int[]
        { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37,
            41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };

        public static void Task_SORED_2()
        {
            //перевірка чи число є простим (шляхом порівняння)
            //якщо число наявне в масиві - вивести повідомлення, що число просте
        }

        static void Main(string[] args)
        {
            Task_SORED_2();
            Console.ReadLine();
        }
    }
}
