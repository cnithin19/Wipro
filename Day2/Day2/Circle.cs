using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Circle
    {
        public void Calculate(double radius)
        {
            double area = Math.PI * radius * radius;
            double circumference = 2 * Math.PI * radius;
            Console.WriteLine("Area of Circle is : {0}", area);
            Console.WriteLine("Circumference of Circle is : {0}", circumference);
        }
        static void Main()
        {
            Console.WriteLine("Enter a radius :");
            double radius = Convert.ToDouble(Console.ReadLine());
            Circle circle = new Circle();
            circle.Calculate(radius);
        } 
    }
}
