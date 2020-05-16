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
        }
    }
}