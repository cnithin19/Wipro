using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Variables
    {
        static void Main()
        {
            Console.WriteLine("Hello, World! from the Variables class");
            // Declare a variable
            int myNumber = 42;
            // Declare a constant
            const string myString = "Hello, World!";
            // Declare a nullable variable
            int? myNullableNumber = null;
            // Declare a variable with an initial value
            double myDouble = 3.14;
            // Declare a variable with an explicit type
            var myImplicitVariable = "This is an implicit variable";
            // Print the variables
            Console.WriteLine($"myNumber: {myNumber}");
            Console.WriteLine($"myString: {myString}");
            Console.WriteLine($"myNullableNumber: {myNullableNumber}");
            Console.WriteLine($"myDouble: {myDouble}");
            Console.WriteLine($"myImplicitVariable: {myImplicitVariable}");

        }
    }
}
