using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    internal class DelegateEx1
    {
        public delegate void  MyDelegate();
        public static void show()
        {
            Console.WriteLine("This is single delegate");
        }

        static void Main()
        {
            MyDelegate obj = new MyDelegate(show);
            obj();
        }
    }
}
