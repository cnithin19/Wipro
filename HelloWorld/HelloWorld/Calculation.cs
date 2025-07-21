using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Calculation
    {
        static void Main()
        {
            int a, b, c;
            Console.WriteLine("Enter 2 numbers :");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("Sum of {0} and {1} is {2}", a, b, c);
            c = a - b;
            Console.WriteLine("Sub is "+c);
            c = a * b;
            Console.WriteLine("Multiply is "+c);
        }
    }
}
