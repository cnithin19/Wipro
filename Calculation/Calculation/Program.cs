using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculationLibrary;

namespace Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculationLibrary.CalculationLib cal = new CalculationLibrary.CalculationLib();
            Console.WriteLine("Enter 2 numbers :");
            int n=Convert.ToInt32(Console.ReadLine());
            int m=Convert.ToInt32(Console.ReadLine());
            cal.sum(n, m);
            cal.sub(n, m);
            cal.mul(n, m);
            

        }
    }
}
