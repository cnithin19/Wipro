using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDay4
{
    internal class ExtentionMain
    {
        static void Main()
        {
            Calculation cal=new Calculation();
            Console.WriteLine("sum of 5 and 8 : "+cal.sum(5,8));
            Console.WriteLine("sub of 580 and 420 : " + cal.sub(580, 420));
            Console.WriteLine("Mul of 50 and 8 : " + cal.mul(50, 8));
        }
    }
}
