using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDay4
{
    internal class staticex234
    {
        static int count;
        public void Increment()
        {
            count++;
        }
        public void Show()
        {
            Console.WriteLine("Count  " + count);
        }
        static void Main()
        {
            staticex234 obj1 = new staticex234();
            staticex234 obj2 = new staticex234();
            obj1.Increment();
            obj1.Show();
            obj2.Increment();
            obj2.Show();
        }
    }
}
