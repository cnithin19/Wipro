using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class String
    {
        static void Main()
        {
           string str="Hello why the string is important. But why the string is important";
            string str2= "Hello World";
            Console.WriteLine("String Length: " + str.Length);
              Console.WriteLine("String in Upper Case: " + str.ToUpper());
                Console.WriteLine("String in Lower Case: " + str.ToLower());
            Console.WriteLine(str.Concat(str2));
            Console.WriteLine("String Contains 'why': " + str.Contains("why"));
            Console.WriteLine("String Starts with 'Hello': " + str.StartsWith("Hello"));
            Console.WriteLine("String Ends with 'important': " + str.EndsWith("important"));
            Console.WriteLine("Index of 'why': " + str.IndexOf("why"));
            Console.WriteLine("Last Index of 'important': " + str.LastIndexOf("important"));
            Console.WriteLine(str.CompareTo(str2));
            Console.WriteLine(str.Equals(str2));
            Console.WriteLine(str.Except(str2));
            Console.WriteLine(str+str2);

        }
    }
}
