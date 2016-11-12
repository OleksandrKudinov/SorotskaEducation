using System;
using System.Security.Cryptography.X509Certificates;

namespace Education.Cmd
{
    class Program
    {
        private static int[,] InitializeMatrix(int x, int y)
        {
            return new int[x, y];
        }

        private static int[,] SetBonuses(int[,] matrix, int bonuseScale, int bonusValue)
        {
            int x;
            int y;

            GetMatrixXY(matrix, out x, out y);
            Random rand = new Random();

            for (int j = 0; j < y; j++)
            {
                for (int i = 0; i < x; i++)
                {
                    matrix[i, j] = rand.Next(0, 100) < bonuseScale ? bonusValue : 0;
                }
            }

            return matrix;
        }

        public static void GetMatrixXY(int[,] matrix, out int x, out int y)
        {
            x = matrix.GetLength(0);
            y = matrix.GetLength(1);
        }

        public static bool ReadStringFromConsole(out string value)
        {
            value = Console.ReadLine();
            return true;
        }

        public static bool InRange(int value, int min, int max)
        {
            bool isInRange = min <= value && value <= max;
            return isInRange;
        }

        public static int ReadInt(int min, int max)
        {
            string rawValue = null;
            int value = 0;
            while (ReadStringFromConsole(out rawValue) && !int.TryParse(rawValue, out value) || !InRange(value, min, max))
            {
                Console.WriteLine("Invalid value! Value must be in range [{0}:{1}]", min, max);
            }
            return value;
        }

        public static void ShowMatrix(int[,] matrix, string values)
        {
            Console.Clear();
            int x;
            int y;
            GetMatrixXY(matrix, out x, out y);

            for (int i = 0; i < x + 2; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();

            for (int j = 0; j < y; j++)
            {
                Console.Write("|");
                for (int i = 0; i < x; i++)
                {
                    Console.Write(values[matrix[i, j]]);
                }
                Console.Write("|");

                Console.WriteLine();
            }

            for (int i = 0; i < x + 2; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }

        private static void ReadNewPosition(ref int x, ref int y)
        {
            while (true)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);

                switch (pressedKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        y--;
                        return;
                    case ConsoleKey.DownArrow:
                        y++;
                        return;
                    case ConsoleKey.RightArrow:
                        x++;
                        return;
                    case ConsoleKey.LeftArrow:
                        x--;
                        return;
                }
            }
        }

        private static int[,] SetPerson(int[,] matrix, int personValue, int oldX, int oldY, int newX, int newY)
        {
            matrix[oldX, oldY] = 0;
            matrix[newX, newY] = personValue;
            return matrix;
        }

        private static void CorrectPersonXYCoordinates(ref int personX, ref int personY, int minX, int maxX, int minY, int maxY)
        {
            if (personX > maxX)
            {
                personX = maxX;
            }
            if (personX < minX)
            {
                personX = minX;
            }
            if (personY > maxY)
            {
                personY = maxY;
            }
            if (personY < minY)
            {
                personY = minY;
            }
        }

        static void Main(string[] args)
        {
            string characters = " +o";
            int personValue = 2;
            int bonusValue = 1;

            Console.Write("x: ");
            int x = ReadInt(0, Console.WindowWidth - 2);
            Console.Write("y: ");
            int y = ReadInt(0, Console.WindowHeight - 2);
            Console.Write("bonus solid percents: ");
            int percents = ReadInt(0, 100);


            int minX = 0;
            int minY = 0;
            int maxX = x - 1;
            int maxY = y - 1;

            Console.Write("person x: ");
            int newX = ReadInt(minX, maxX);
            Console.Write("person y: ");
            int newY = ReadInt(minY, maxY);

            var matrix = InitializeMatrix(x, y);
            matrix = SetBonuses(matrix, percents, bonusValue);

            int oldX;
            int oldY;

            matrix = SetPerson(matrix, personValue, newX, newY, newX, newY);
            ShowMatrix(matrix, characters);

            while (true)
            {
                oldX = newX;
                oldY = newY;
                ReadNewPosition(ref newX, ref newY);
                CorrectPersonXYCoordinates(ref newX, ref newY, minX, maxX, minY, maxY);
                matrix = SetPerson(matrix, personValue, oldX, oldY, newX, newY);
                ShowMatrix(matrix, characters);
            }
        }
    }
}
