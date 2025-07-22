using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Boxing
    {
        public void box(object n)
        {
            string str= n.GetType().Name;
            Console.WriteLine(n.GetType().Name);
            if(str.Equals("String"))
            {
                string s = (String)n;
                Console.WriteLine("The variable is of type string."+s);
            }
            else if (str.Equals("Int32"))
            {
                int i = (Int32)n;
                Console.WriteLine("The variable is of type integer."+i);
            }
            else if (str.Equals("Double"))
            {
                double d = (Double)n;
                Console.WriteLine("The variable is of type double."+d);
            }
            else if (str.Equals("Boolean"))
            {
                bool b = (Boolean)n;
                Console.WriteLine("The variable is of type boolean."+b);
            }
            else
            {
                Console.WriteLine("The variable is not of type.");
            }
          //  Console.WriteLine("The type of the variable is: " + str);
        }

        static void Main()
        {
            Console.WriteLine("Enter a variable of type string, integer, double, or boolean: ");
            string n = Console.ReadLine();
            object nn = n; // Boxing the input to object type
            Boxing boxing = new Boxing();
            //  Console.WriteLine(nn.GetType().Name);
            object n1 = true;
            object n2 = 10;
            object n3 = 10.5;
            object n4 = "Hello";
            boxing.box(n1);
            boxing.box(n2);
            boxing.box(n3);
            boxing.box(n4);

        }
    }
}
