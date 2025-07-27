using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class MyException:ApplicationException
    {
        public MyException(string e):base(e) {
          // e = "this is an error";
        }
    }
}
