using System;
using System.Security.Cryptography.X509Certificates;

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
        public static void ShowMatrix(int[,] matrix)
        {
            Console.Clear();
            int x = matrix.GetLength(0);
            int y = matrix.GetLength(1);
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
                            Console.Write(" ");
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
        public static int[] GetNewCoordinates(int x, int y)
        {
            while (true)
            {
                ConsoleKeyInfo info = Console.ReadKey(false);
                switch (info.Key)
                {
                    case ConsoleKey.UpArrow:
                        y--;
                        break;
                    case ConsoleKey.DownArrow:
                        y++;
                        break;
                    case ConsoleKey.LeftArrow:
                        x--;
                        break;
                    case ConsoleKey.RightArrow:
                        x++;
                        break;
                    default:
                        continue;
                }
                return new int[] { x, y };
            }
        }

        public static int[,] Inizialaized()
        {
            Console.WriteLine("Please write value x");
            int x = ReadIntFromConsole();
            Console.WriteLine("Please write value y");
            int y = ReadIntFromConsole();
            int[,] matrix = new int[x, y];
            return matrix;
        }

        public static int[,] SetBonus(int[,] matrix)
        {
            Console.WriteLine("Write please virogidnist");
            int v = ReadIntFromConsole();
            int x = matrix.GetLength(0);
            int y = matrix.GetLength(1);
            Random rnd = new Random();
            for (int j = 0; j < y; j++)
            {
                for (int i = 0; i < x; i++)
                {
                    if (rnd.Next(0, 100) <= v)
                    {
                        matrix[i, j] = 1;
                    }
                }
            }
            return matrix;
        }

        public static int[] SetPersone(int x, int y)
        {
            Console.Write("Please write coordinate x for persone ");
            int personX = ReadIntFromConsole();
            Console.Write("Please write coordinate y for persone ");
            int personY = ReadIntFromConsole();
            while (true)
            {


                if (personX < x && personX >= 0 && personY < y && personY >= 0)
                {

                    int[] arr = new int[] { personX, personY };
                    return arr;
                }
                else
                {
                    Console.WriteLine("Write corect  x,y for persone");

                }
            }
        }

        public static void Task_SORED_12()
        {
            int[,] matrix = Inizialaized();
            int x = matrix.GetLength(0) - 1;
            int y = matrix.GetLength(1) - 1;
            matrix = SetBonus(matrix);
            int[] point = SetPersone(x, y);
            matrix[point[0], point[1]] = 2;

            Console.WriteLine();

            int[] newpoint = point;
            while (true)
            {
                ShowMatrix(matrix);
                point = newpoint;
                newpoint = GetNewCoordinates(point[0], point[1]);
                matrix[point[0], point[1]] = 0;
                if (newpoint[0] >= matrix.GetLength(0))
                {
                    newpoint[0] = matrix.GetLength(0) - 1;
                }
                if (newpoint[0] < 0)
                {
                    newpoint[0] = 0;
                }
                if (newpoint[1] >= matrix.GetLength(1))
                {
                    newpoint[1] = matrix.GetLength(1) - 1;
                }
                if (newpoint[1] < 0)
                {
                    newpoint[1] = 0;
                }
                matrix[newpoint[0], newpoint[1]] = 2;

            }
        }
        static void Main(string[] args)
        {
            Task_SORED_12();
            Console.ReadLine();

        }
    }
}
