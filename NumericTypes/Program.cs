using System;

namespace NumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaOfRectangle;
            string input;
            double length;
            double breadth;
            Console.WriteLine("Enter the length of the rectangle:");
            input = Console.ReadLine();
            length = double.Parse(input);
            Console.WriteLine("Enter the Breadth of the rectangle:");
            input = Console.ReadLine();
            breadth = double.Parse(input);
            areaOfRectangle = length * breadth;
            Console.WriteLine("Area of the rectangle is: " + areaOfRectangle);
            //Console.ReadLine();





            
        }
    }
}
