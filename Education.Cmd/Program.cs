using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using Microsoft.SqlServer.Server;

namespace Education.Cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] {1, 2, 3, 5, 7, 11, 13, 17, 19, 23};

            //обчислити і вивести 
            //суму
            int sum = 0;
            for (int j = 0; j < 10 ; j++)
            {
                sum += arr[j];

            }
            Console.WriteLine("sum={0}",sum);
            //добуток
            int dob = 1;

            for (int j = 0; j < 10; j++)
            {
                dob *= arr[j];

            }
            Console.WriteLine("dob={0}", dob);

            //середнє

            double ser = (double)sum/10;
            Console.WriteLine("ser={0}", ser);
            //середнє квадратичне
            int sumkvkv = 0;
            for (int i = 0; i < 10; i++)
            {
                sumkvkv += arr[i]*arr[i];
            }
            double serkv = (double)sumkvkv/10;
           double a= Math.Sqrt(serkv);
            Console.WriteLine(a);

            Console.ReadLine();
        }
    }
}
