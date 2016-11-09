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

        public static void Task_SORED_4()
        {
            //            Використовуючи список з простих чисел від 2 до 97,
            //            порахувати середнє квадратичне усіх остач від ділення простого 
            //            двозначного числа на останню цифру цього числа.

            //приклад ділення:
            //11 / 1
            //13 / 3
            //17 / 7
            //19 / 9
            //23 / 3
            //...

            //результат програми:
            //3.4364987719369
            int ostacha = 0;
            double sumKvOst = 0;
            double divideResult = 0;
            int coutn = 0;
            for (int i = 0; i < primeNumbers.Length; i++)
            {
                if (primeNumbers[i] >= 10)
                {
                    ostacha = primeNumbers[i] % 10;
                    divideResult = ((double)primeNumbers[i]) % ostacha;
                    sumKvOst += divideResult * divideResult;
                    coutn++;
                }

            }
            double serSumKvDivideResult = sumKvOst / coutn;
            double result = Math.Sqrt(serSumKvDivideResult);
            Console.WriteLine(result);


        }

        static void Main(string[] args)
        {
            Task_SORED_4();
            Console.ReadLine();
        }
    }
}
