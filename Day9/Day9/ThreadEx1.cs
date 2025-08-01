using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day9
{

    internal class ThreadEx1
    {
        void Table2()
        {
            
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("2table : "+2*i);
                Thread.Sleep(3000);
            }
           

        }
        void Table3()
        {
           
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("3table :"+3 * i);
                Thread.Sleep(1000);
            }
            
        }
        void Table4()
        {
            
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("4table :" + 4 * i);
                Thread.Sleep(2000);
                }
              //  Thread.Sleep(4000);
            
        }
        static void Main()
        {
            ThreadEx1 threadEx1 = new ThreadEx1();
            ThreadStart the1 = new ThreadStart(threadEx1.Table2);
            ThreadStart the2= new ThreadStart(threadEx1.Table3);
            ThreadStart the3 = new ThreadStart(threadEx1.Table4);

            Thread t1 = new Thread(the1);
            Thread t2 = new Thread(the2);
            Thread t3 = new Thread(the3);

            t1.Start();
            t2.Start();
            t1.Join();
            t3.Start();
            


            //threadEx1.Table2();
            //threadEx1.Table3();
            //threadEx1.Table4();
        }
    }
}
