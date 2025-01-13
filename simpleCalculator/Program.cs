using System;

namespace simpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("give me two numbers:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("give me a second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int addition = num1 + num2;
            int subtraction = num1 - num2;
            int multiplication = num1 * num2;
            int division = num1 / num2;

            Console.WriteLine("addition: " + addition);
            Console.WriteLine("subtraction: " + subtraction);
            Console.WriteLine("multiplication: " + multiplication);
            Console.WriteLine("division: " + division);
            Console.ReadLine();
        }
    }
}
