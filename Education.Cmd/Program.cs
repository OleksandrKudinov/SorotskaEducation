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

        public static void Task_SORED_2()
        {
            //перевірка чи число є простим (шляхом порівняння)
            //якщо число наявне в масиві - вивести повідомлення, що число просте
        }

        static void Task_SORED_1()
        {
            int[] arr = new int[10] {1, 2, 3, 5, 7, 11, 13, 17, 19, 23};

            //обчислити і вивести 
            //суму
            int sum = 0;
            for (int j = 0; j < 10; j++)
            {
                sum += arr[j];

            }
            Console.WriteLine("sum={0}", sum);
            //добуток
            int dob = 1;

            for (int j = 0; j < 10; j++)
            {
                dob *= arr[j];

            }
            Console.WriteLine("dob={0}", dob);

            double ser = (double) sum/10;
            Console.WriteLine("ser={0}", ser);
            //середнє квадратичне
            int sumkvkv = 0;
            for (int i = 0; i < 10; i++)
            {
                sumkvkv += arr[i]*arr[i];
            }
            double serkv = (double) sumkvkv/10;
            double a = Math.Sqrt(serkv);
            Console.WriteLine(a);
        }

        static void Main(string[] args)
        {
            Task_SORED_2();
            Console.ReadLine();
        }
    }
}
