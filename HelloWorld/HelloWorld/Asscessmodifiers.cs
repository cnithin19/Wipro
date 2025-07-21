using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Asscessmodifiers
    {
        public void PublicMethod()
        {
            Console.WriteLine("This is a public method.");
        }
        private void PrivateMethod()
        {
            Console.WriteLine("This is a private method.");
        }
        internal void InternalMethod()
        {
            Console.WriteLine("This is an internal method.");
        }
        
    }
}
