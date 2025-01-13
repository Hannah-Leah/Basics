namespace switchcase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int test = 2;

            switch (test)
            {
                case 0: Console.WriteLine("value is 0"); break;
                case <=4: Console.WriteLine("Value is less than 4"); break;
                case 5: Console.WriteLine("value is 5"); break;
                case 10: Console.WriteLine("Value is 10"); break;
                    default: Console.WriteLine("default"); break;

                 
            }

            // making a calculator with the switch case:

            Console.WriteLine("Give me two numbers:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("give me a second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What do you want to do with the numbers? \n input: *, + , - , / ");
            string operation = Convert.ToString(Console.ReadLine());

            switch (operation)
            {
                case "*":
                    int multiplication = num1 * num2;
                    Console.WriteLine("result: " + multiplication);
                    break;

                case "+":
                    int addition = num1 + num2;
                    Console.WriteLine("result: " + addition);
                    break;

                    case "-":
                    int subtraction = num1 - num2;
                    Console.WriteLine("result: " + subtraction);
                    break;

                case "/":
                    try
                    {
                        int divison = num1 / num2;
                        Console.WriteLine("result: " + divison);
                    }

                    catch
                    {
                        Console.WriteLine("divison with 0 not possible.");
                    }

                    break;

                default : 
                    Console.WriteLine("default"); 
                    break;
            }
        }
    }
}
