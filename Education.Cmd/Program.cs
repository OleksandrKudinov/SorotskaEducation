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
        public static void ShowMatrix(int[,] matrix, int x, int y)
        {
            for (int i = 0; i < x+2; i++)
            {
                Console.Write("_");
          
            }
            Console.WriteLine();
            for (int j = 0; j < y; j++)
            {

                Console.Write("|");

                for (int i = 0; i < x; i++)
                {
                    
                    if (matrix[i, j] == 1)
                    {
                        Console.Write((char)0x2665);
                    }
                    else
                    {
                        Console.Write("+");
                    }
                    //Console.Write(matrix[i,j]);
                }
                Console.WriteLine("|" );
            }
            for (int i = 0; i < x + 2; i++)
            {
                Console.Write("-");

            }
          
        }
        public static void Task_SORED_9()
        {
            Console.WriteLine("Please write value x");
            int x = ReadIntFromConsole();
            Console.WriteLine("Please write value y");
            int y = ReadIntFromConsole();
            Console.WriteLine("Write please virogidnist");
            int v = ReadIntFromConsole();
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            int[,] matrix = new int[x, y];
            Random rnd = new Random();
            for (int j = 0; j < y; j++)
            {
                for (int i = 0; i < x; i++)
                {
                    if (rnd.Next(0, 100) <= v)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }

                }
                //  Console.WriteLine();
            }
            ShowMatrix(matrix, x, y);

        }
        static void Main(string[] args)
        {
            Console.WriteLine((char)0x2665);
            string s = ((char)0x2665).ToString();
            Console.WriteLine(s);
            Task_SORED_9();
            Console.ReadLine();
        }
    }
}
