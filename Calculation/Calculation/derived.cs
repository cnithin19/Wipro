using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    internal class derived:Check
    {
        static void Main()
        {
            Check check = new Check();
            Console.WriteLine("This is public " + check.npublic);
         //   Console.WriteLine(check.nprivate);
         //   Console.WriteLine(check.nprotected);
            Console.WriteLine(check.npinternal);
            Console.WriteLine(check.ninternal);
        }
    }
}
