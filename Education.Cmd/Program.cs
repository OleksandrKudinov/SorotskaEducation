using System;
namespace Education.Cmd
{
    class Program
    {
        static int[] primeNumbers = new int[]
        { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37,
            41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };

        public static int GetIndexType()
        {
            int intShchos;
            bool isParsed;
            bool isOk = false;
            bool isInrange = false;
            do
            {
                isParsed = int.TryParse(Console.ReadLine(), out intShchos);
                if (isParsed)
                {
                    isInrange = intShchos <= 3 && intShchos >= 0;

                }
                isOk = isParsed && isInrange;
                if (!isOk)
                {
                    Console.WriteLine("Error, please type the correct value");
                }


            } while (!isOk);
            return intShchos;
        }

        public static void ReadInt()
        {
            bool parse = true;

            do
            {
                int chuslo;
                Console.Write("Set value for type  int:");
                string rawvalue = Console.ReadLine();
                parse = int.TryParse(rawvalue, out chuslo);
                if (parse == false)
                {
                    Console.WriteLine("Error! cannot parse '{0}' to int ", rawvalue);

                }
                else
                {
                    Console.WriteLine("Int value is {0}", chuslo);
                    Console.WriteLine();

                }
            } while (!parse);
        }

        public static void ReaDouble()
        {
            bool parse = true;

            do
            {
                double chuslo;
                Console.Write("Set value for type  double:");
                string rawvalue = Console.ReadLine();
                parse = double.TryParse(rawvalue, out chuslo);
                if (parse == false)
                {
                    Console.WriteLine("Error! cannot parse '{0}' to double ", rawvalue);

                }
                else
                {
                    Console.WriteLine("double value is {0}", chuslo);
                    Console.WriteLine();

                }
            } while (!parse);
        }

        public static void ReadBool()
        {
            bool parse = true;

            do
            {
                bool chuslo;
                Console.Write("Set value for type  bool:");
                string rawvalue = Console.ReadLine();
                parse = bool.TryParse(rawvalue, out chuslo);
                if (parse == false)
                {
                    Console.WriteLine("Error! cannot parse '{0}' to bool ", rawvalue);

                }
                else
                {
                    Console.WriteLine("Bool value is {0}", chuslo);
                    Console.WriteLine();

                }
            } while (!parse);
        }

        public static void ReadByte()
        {
            bool parse = true;

            do
            {
                byte chuslo;
                Console.Write("Set value for type  byte:");
                string rawvalue = Console.ReadLine();
                parse = byte.TryParse(rawvalue, out chuslo);
                if (parse == false)
                {
                    Console.WriteLine("Error! cannot parse '{0}' to byte ", rawvalue);

                }
                else
                {
                    Console.WriteLine("byte value is {0}", chuslo);
                    Console.WriteLine();

                }
            } while (!parse);
        }

        public static void Task_SORED_6()
        {
            //Дослідити методи простих типів:
            //T Parse(string value);
            //bool TryParse(string value, out T);
            //Використовуючи навички, здобуті в SORED-5, зчитати значення з клавіатури і перетворити у відповідні типи.
            //Приклад програми - скріншот
            string choise;
            do
            {


                Console.WriteLine("bool -0\nbyte-1\nint-2\ndouble-3");
                Console.Write("Select data type: ");
                int indexType = GetIndexType();
                switch (indexType)
                {
                    case 0:
                        {
                            ReadBool();
                            break;
                        }
                    case 1:
                        {
                            ReadByte();
                            break;
                        }

                    case 2:
                        {
                            ReadInt();
                            break;
                        }
                    case 3:
                        {
                            ReaDouble();
                            break;
                        }
                }
                Console.Write("Would you like to continue?(y/n)");
                choise = Console.ReadLine();
            } while (choise == "y");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Task_SORED_6();
            Console.ReadLine();
        }
    }
}
