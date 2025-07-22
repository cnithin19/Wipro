using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class CtoF
    {
        public double ConvertCtoF(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
        static void Main()
        {
            Console.WriteLine("Enter temperature in Celsius: ");
            double celsius=Convert.ToDouble(Console.ReadLine());
            CtoF converter = new CtoF();
            double fahrenheit = converter.ConvertCtoF(celsius);
            Console.WriteLine("Celsius {0} to Fahrenheit is {1} .",celsius,fahrenheit);
        }
    }
}
