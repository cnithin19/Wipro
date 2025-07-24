using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDay4
{
    internal class ExceptionEx
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter 2 numbers :");
            double n = Convert.ToDouble(Console.ReadLine());
            double m = Convert.ToDouble(Console.ReadLine());

                double x = n / m;
                Console.WriteLine($"Divide of {n} and {m} is : {x}.");
            }
            catch (Exception e)
            {
                switch (e)
                {
                    case DivideByZeroException _:
                        Console.WriteLine("Error: Cannot divide by zero.");
                        break;
                    case FormatException _:
                        Console.WriteLine("Error: Invalid input format. Please enter valid integers.");
                        break;
                    case OverflowException _:
                        Console.WriteLine("Error: Number is too large or too small.");
                        break;
                    default:
                        Console.WriteLine("An unexpected error occurred: " + e.Message);
                        break;
                }
            }
        }
    }
}
