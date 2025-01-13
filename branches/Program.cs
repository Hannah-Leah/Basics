using System.ComponentModel.Design;

namespace branches
{
    internal class Program
    {
        static void Main(string[] args)


        {

            Console.WriteLine("give me a number:");
            int test = int.Parse(Console.ReadLine());

            if (test > 10)
            {
                Console.WriteLine("number is above 10");
            }
            else if (test <= 10 && test > 0)
            {
                Console.WriteLine("Number is betwwen 0 and 11");
            }
            else
            {

                Console.WriteLine("number is 0 or smaller");

            }

            if (test >= 0)
            {
                Console.WriteLine("number is positive");
            }
            else
            {
                Console.WriteLine("number is negative");
            }
            Console.WriteLine("Here is the end!");
        }
    }
}
