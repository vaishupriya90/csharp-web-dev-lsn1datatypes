using System;

namespace MoreNumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles , gas ,milesPerGallon;
            string input;
            Console.WriteLine("Enter the number of miles driven:");
            input = Console.ReadLine();
            miles = double.Parse(input);
            Console.WriteLine("Enter the amount of gas consumed:");
            input = Console.ReadLine();
            gas = double.Parse(input);
            milesPerGallon = miles / gas;
            Console.WriteLine("Miles per gallon is: " + milesPerGallon);





        }
    }
}
