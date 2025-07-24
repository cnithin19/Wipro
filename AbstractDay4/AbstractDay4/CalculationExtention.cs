using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDay4
{
    internal static class CalculationExtension
    {
        public static int mul(this Calculation cal, int n, int m)
        {
            return n * m;
        }
    }
}
