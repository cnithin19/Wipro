using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class Nullable
    {
        static void Main()
        {
            int? n = null;
            Nullable<int> m = null;
            Console.WriteLine(n.GetValueOrDefault());
            string str=null;
            Console.WriteLine(str ?? "it is null");
            Console.WriteLine(str);

            Console.WriteLine("Enter number n:");
            n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n.GetValueOrDefault());
        }
    }
}
