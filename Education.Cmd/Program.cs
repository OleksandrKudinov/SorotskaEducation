using System;
namespace Education.Cmd
{
    class Program
    {
        public static int ReadIntFromConsole()
        {
            bool parser = true;
            int chuslo;
            do
            {
                string rawIntValue = Console.ReadLine();
                parser = int.TryParse(rawIntValue, out chuslo);
                if (parser == false)
                {
                    Console.WriteLine("Error! cannot parse '{0}' to int ", rawIntValue);
                }
            } while (!parser);
            return chuslo;
        }
        public static void Task_SORED_7()
        {

            Console.WriteLine("Please write value y");
            int x = ReadIntFromConsole();
            Console.WriteLine("Please write value x");
            int y = ReadIntFromConsole();
            Console.WriteLine("Write please virogidnist");
            int v = ReadIntFromConsole();
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            int[,] matrix = new int[x, y];
            Random rnd = new Random();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (rnd.Next(0, 100) <= v)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                    Console.Write(matrix[i, j]);

                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Task_SORED_7();
            Console.ReadLine();
        }
    }
}
