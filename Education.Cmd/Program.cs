using System;

namespace Education.Cmd
{
    class Program
    {
        static int[] primeNumbers = new int[]
        { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37,
            41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };

        static int GetSelectItemIndex(string[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine("{0} - {1}", items[i], i);
            }

            string rawValue;
            int index = -1;
            string message = "Select type: ";

            Console.Write(message);
            while (ReadString(out rawValue) && !int.TryParse(rawValue, out index) && index >= 0 && index < items.Length)
            {
                Console.WriteLine("Invalid type!");
                Console.WriteLine(message);
            }
            return index;
        }

        static bool ReadString(out string value)
        {
            value = Console.ReadLine();
            return true;
        }

        static void ErrorMessage(string incorrectValue, string type)
        {
            Console.WriteLine("Error! Cannot parse '{0}' to {1}", incorrectValue, type);
        }

        static void MessageForSettingType(string type)
        {
            Console.Write("Set {0} value: ", type);
        }

        static void ProcessError(string incorrectValue, string type)
        {
            ErrorMessage(incorrectValue, type);
            MessageForSettingType(type);
        }

        static void Main(string[] args)
        {
            string[] types = new[] { "bool", "byte", "int", "double" };

            string choise = null;
            do
            {
                int typeIndex = GetSelectItemIndex(types);

                string rawValue;
                string parsedValue = null;
                string selectedType = types[typeIndex];

                MessageForSettingType(types[typeIndex]);

                switch (typeIndex)
                {
                    case 0:
                        bool boolValue = false;
                        while (ReadString(out rawValue) && !bool.TryParse(rawValue, out boolValue))
                        {
                            ProcessError(rawValue, selectedType);
                        }
                        parsedValue = boolValue.ToString();
                        break;
                    case 1:
                        byte byteValue = 0;
                        while (ReadString(out rawValue) && !byte.TryParse(rawValue, out byteValue))
                        {
                            ProcessError(rawValue, selectedType);
                        }
                        parsedValue = byteValue.ToString();
                        break;
                    case 2:
                        int intValue = 0;
                        while (ReadString(out rawValue) && !int.TryParse(rawValue, out intValue))
                        {
                            ProcessError(rawValue, selectedType);
                        }
                        parsedValue = intValue.ToString();
                        break;
                    case 3:
                        double doubleValue = 0;
                        while (ReadString(out rawValue) && !double.TryParse(rawValue, out doubleValue))
                        {
                            ProcessError(rawValue, selectedType);
                        }
                        parsedValue = doubleValue.ToString();
                        break;
                }

                Console.WriteLine("{0} value is {1}", types[typeIndex], parsedValue);

                Console.Write("Continue? <y/n>");
            } while (ReadString(out choise) && choise == "y");

            Console.ReadLine();
        }
    }
}
