using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    internal class Reflectionex1
    {

        static void Main()
        {
            Type typeObj = typeof(Test);
            Console.WriteLine("Methods Avaialble in Tes Class Are");
            foreach (MethodInfo mi in typeObj.GetMethods())
            {
                Console.WriteLine(mi.Name);
            }
            Console.WriteLine("Variables available in the class are ");
            foreach (FieldInfo fi in typeObj.GetFields())
            {
                Console.WriteLine(fi.Name);



            }
            Type tt=typeof(StringBuilder);
            Console.WriteLine("Name  " + tt.Name);
            Console.WriteLine("Full Name  " + tt.FullName);
            Console.WriteLine("Namespace  " + tt.Namespace);
            Console.WriteLine("Base Type  " + tt.BaseType);

            Type t = typeof(string);
            Console.WriteLine("Name  " + t.Name);
            Console.WriteLine("Full Name  " + t.FullName);
            Console.WriteLine("Namespace  " + t.Namespace);
            Console.WriteLine("Base Type  " + t.BaseType);
        }
    }
}
