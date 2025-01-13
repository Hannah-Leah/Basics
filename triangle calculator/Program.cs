using System.Diagnostics.CodeAnalysis;

namespace triangle_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is the base of the triangle?");
            string triangleBaseText = Console.ReadLine();
            int triangleBase = Convert.ToInt32(triangleBaseText);

            Console.WriteLine("what is the height of the triangle?");
            string triangleHeightText = Console.ReadLine();
            int triangleHeight = Convert.ToInt32(triangleHeightText);

            int areaOfTriangle = triangleBase * triangleHeight / 2;

            Console.WriteLine("the area of the triangle is " + areaOfTriangle);

            Console.WriteLine("Enter the side1 of the triangle:");

            double triangleSide1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the side2 of the triangle");

            double triangleSide2 = Convert.ToDouble(Console.ReadLine());  

            double circumference = 2 * triangleSide1 + triangleSide2;

            Console.WriteLine("The circumference of the triangle is " + circumference);
            Console.ReadLine();


        }
    }
}
