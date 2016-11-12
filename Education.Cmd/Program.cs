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
            for (int i = 0; i < x + 2; i++)
            {
                Console.Write("_");

            }
            Console.WriteLine();
            for (int j = 0; j < y; j++)
            {

                Console.Write("|");

                for (int i = 0; i < x; i++)
                {

                    switch (matrix[i, j])
                    {
                        case 0:
                            Console.Write("+");
                            break;
                        case 1:
                            Console.Write((char)0x2665);
                            break;
                        case 2:
                            Console.Write("☺");
                            break;
                    }

                }
                Console.WriteLine("|");
            }
            for (int i = 0; i < x + 2; i++)
            {
                Console.Write("-");

            }
            Console.WriteLine();
        }
        public static void Task_SORED_10()
        {
            Console.WriteLine("Please write value x");
            int x = ReadIntFromConsole();
            Console.WriteLine("Please write value y");
            int y = ReadIntFromConsole();
            Console.WriteLine("Write please virogidnist");
            int v = ReadIntFromConsole();
            Console.Write("Please write coordinate x for persone ");
            int personX = ReadIntFromConsole();
            Console.Write("Please write coordinate y for persone ");
            int personY = ReadIntFromConsole();

            if (personX < x && personX >= 0 && personY < y && personY >= 0)
            {
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
                }
                matrix[personX, personY] = 2;
                ShowMatrix(matrix, x, y);
            }
            else
            {
                Console.WriteLine("Write corect  x,y for persone");
            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine((char)0x2665);
            string s = ((char)0x2665).ToString();
            Console.WriteLine(s);
            Task_SORED_10();
            Console.ReadLine();
        }
    }
}
