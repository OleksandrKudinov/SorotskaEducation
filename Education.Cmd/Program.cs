using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Education.Cmd
{
    class Program
    {

        public static void Counter_Task_SORED_11()
        {
            Console.Write("Please write x ");
            int x;
            string xs = Console.ReadLine();
            bool resultX = int.TryParse(xs, out x);
            Console.Write("Please write y ");
            int y;
            string ys = Console.ReadLine();
            bool resultY = int.TryParse(ys, out y);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine("Please tap button up down left reight for move smile");
            while (true)
            {
                ConsoleKeyInfo info = Console.ReadKey(false);
                var key = info.Key;
                switch (info.Key)
                {
                    case ConsoleKey.UpArrow:
                        {
                            y++;

                        }
                        break;
                    case ConsoleKey.DownArrow:
                        {
                            y--;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        {
                            x--;

                        } break;

                    case ConsoleKey.RightArrow:
                        {
                            x++;
                        }
                        break;
                     }
                //Console.WriteLine("x= {0}",x);
                //Console.WriteLine("y= {0}", y);
            }
        }
        static void Main(string[] args)
        {
            Counter_Task_SORED_11();
            Console.ReadLine();
        }
        }
}
