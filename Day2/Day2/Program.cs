using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number :");
          string a=  Console.ReadLine();
            int n = Convert.ToInt32(a);
            Console.WriteLine("Your number is : {0}",n);
        }
    }
}
