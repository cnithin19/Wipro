using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class ExceptionMine
    {

  
        static void Main()
        {
            try
            {
                int x = 7, y = 0;
                Console.WriteLine(x/y);
            }
            catch(MyException e) {
                MyException(e);
            }
        }


    }
}
