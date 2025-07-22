using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    /// <summary>
    /// Selecting the maximum of three numbers.
    /// </summary>

    internal class Max3
    {
       

        public int Max(int a, int b, int c)
        {
            int m = a;
            if (b > m)
            {
                m = b;
            }
            if (c > m)
            {
                m = c;
            }
            return m;
        }
        
        static void Main()
        {
            Console.WriteLine("Enter 3 numbers to find max of 3 : ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Max3 max3 = new Max3();
            int max = max3.Max(a, b, c);
            Console.WriteLine("Maximum of {0}, {1}, {2} is : {3}", a, b, c, max);
        }

    }
}
