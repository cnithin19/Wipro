using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDay4
{
    //static class
    static class staclass
    {
        static int n = 1;
        // Change from private (default) to public so it is accessible
        public static void show()
        {
            
            Console.WriteLine("This is static class method " + n++);
        }
    }


    internal class StaticEx1
    {
        //static int
        int j = 5;
        static int i = 6;

        //static method
        public static void sta(int i)
        {
            
            i++;
        }

        static void Main()
        {
            StaticEx1 st = new StaticEx1();
            StaticEx1 st1 = new StaticEx1();
            Console.WriteLine("normal int :"+st.j+" "+(++st.j)+" "+(++st.j));
            Console.WriteLine("normal "
                +st1.j);
            Console.WriteLine("Static int : "+i+" "+(++i)+" "+(++i));
            Console.WriteLine("static "+i);

            sta(i);
            sta(i);
            Console.WriteLine("After 2   static method exe then  if value is 6 then " + i);
            staclass.show();
            staclass.show(); 
            staclass.show();



        }
    }
}
