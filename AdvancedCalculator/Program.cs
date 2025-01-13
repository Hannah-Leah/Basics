using System.Numerics;

namespace AdvancedCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me two numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("give me a second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What do you want to do with the numbers? \n input: *, + , - , /, %");
            string input = Convert.ToString(Console.ReadLine());

            if ( input == "*")
            {
                int multiplication = num1 * num2;
                Console.WriteLine("result: " + multiplication);          
            }
            else if ( input == "+")
            {
                int addition = num1 + num2;
                Console.WriteLine("result: " + addition);
            }
            else if ( input == "-")
            {
                int subtraction = num1 - num2;
                Console.WriteLine("result: " + subtraction);
            }

            else if ( input == "/")
            {
                try
                {
                    int divison = num1 / num2;
                    Console.WriteLine("result: " + divison);
                }
                
                catch
                {
                    Console.WriteLine("divison with 0 not possible.");
                }
            }

            else if ( input == "%")
            {
                int remainder = num1 % num2;
                Console.WriteLine("result: " + remainder);
            }
            else
            {
                Console.WriteLine("invalid input.");
            }
        }
    }
}
