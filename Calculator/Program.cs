using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string first;
            string second;
            int first_number;
            int second_number;

            Console.WriteLine("Enter first number: ");
            first = Console.ReadLine();
            Console.WriteLine("Enter operator: ");
            string operate = Console.ReadLine();
            Console.WriteLine("Enter second number: ");
            second = Console.ReadLine();
            first_number = Convert.ToInt16(first);
            second_number = Convert.ToInt16(second);
            Console.WriteLine("=");
            switch (operate)
            {
                case "+":
                    Console.WriteLine(first_number + second_number);
                    break;
                case "-":
                    Console.WriteLine(first_number - second_number);
                    break;
                case "*":
                    Console.WriteLine(first_number * second_number);
                    break;
                case "/":
                    Console.WriteLine((double)first_number / (double)second_number);
                    break;
                case "//":
                    Console.WriteLine(first_number / second_number);
                    break;
                case "^":
                    int result = 1;
                    for (int i=0; i< second_number; i++)
                    {
                        result *= first_number;
                    }
                    Console.WriteLine(result);
                    break;
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}