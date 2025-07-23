using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationLibrary
{
    internal class libcheck
    {
        public int npublic = 1;
        private int nprivate = 1;
        protected int nprotected = 1;
        internal int ninternal = 1;
        protected internal int npinternal = 1;

        static void Main()
        {
            Check check = new Check();
            Console.WriteLine("This is public " + check.npublic);
        //    Console.WriteLine(check.nprivate);      // Still inaccessible, will cause CS0122
                                                    // Console.WriteLine(check.nprotected); // FIX: Remove or comment out this line
            Console.WriteLine(check.npinternal);
            Console.WriteLine(check.ninternal);
        }
    }
}
