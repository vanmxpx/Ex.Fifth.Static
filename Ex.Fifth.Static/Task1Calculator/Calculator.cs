using System;

namespace Ex.Fifth.Static
{
    static class Calculator
    {
        private static bool correct;
        private static double value1, value2;
        private static char operation;

        static Calculator()
        {
            correct = false;
            value1 = 0;
            value2 = 0;
            operation = '0';
        }
        public static void Run()
        {
            Console.WriteLine("Program calculator.");
            Console.WriteLine("Action operators: '+', '-', '*', '/'");
            while (!correct)
            {
                try
                {
                    Console.Write("Enter first value: ");
                    value1 = Double.Parse(Console.ReadLine());
                    Console.Write("Enter second value: ");
                    value2 = Double.Parse(Console.ReadLine());
                    Console.Write("Enter operation: ");
                    operation = Char.Parse(Console.ReadLine());
                    correct = true;

                    switch (operation)
                    {
                        case '+':
                            Console.WriteLine("{0}+{1}={2};", value1, value2, value1 + value2);
                            break;
                        case '-':
                            Console.WriteLine("{0}-{1}={2};", value1, value2, value1 - value2);
                            break;
                        case '*':
                            Console.WriteLine("{0}*{1}={2};", value1, value2, value1 * value2);
                            break;
                        case '/':
                            Console.WriteLine("{0}/{1}={2};", value1, value2, value1 / value2);
                            break;
                        default:
                            Console.WriteLine("Invalid operatot, try again.");
                            correct = false;
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Incorrect value, try again.");
                        correct = false;
                }

            }
        }
    }
}
