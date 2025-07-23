using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
  //  public int p = 5;
    class a
    {
        public int p = 5, q = 6;
        public a()
        {
            
            Console.WriteLine(p+" "+q);
        }
        public void show()
        {
            Console.WriteLine(p + " " + q);
        }
        
    }
    static class c
    {
       static c()
        {
            int m = 5, n = 9;
            Console.WriteLine("This is static");
        }
    }
    class b:a
    {
        int x = 9,y=10;

        public b() {

            Console.WriteLine(x+" "+y+" "+p+" "+q);
        }
    }

    internal class Inheritance
    {
        static void Main()
        {
            a classa=new a();
            //a.show();
            Console.WriteLine("This is Main");
           // c classc = new c();
           // Console.WriteLine(m);
        }
    }
}
