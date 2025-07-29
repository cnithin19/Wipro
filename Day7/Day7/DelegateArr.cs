using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    internal class DelegateArr 
    {
        public delegate string del(int n,int m);
        public static string Check(int n)
        {
            {
                return (n >= 0) ? "positive" : "negative";
            }
        }
        public static void action()
        {
            Console.WriteLine("This is Action");
        }
        public static string CheckSum(int n, int m)
        {
            int x = n + m;

            return $"sum of {n} and {m} is {x}.";
        }
        public static string CheckSub(int n, int m)
        {
            int x = n - m;

            return $"sum of {n} and {m} is {x}.";
        }
        public static string CheckMult(int n, int m)
        {
            int x = n * m;

            return $"sum of {n} and {m} is {x}.";
        }
        public static bool VoteEligible(int n)
        {
            return (n >= 18) ? true : false;

        }


        static void Main()
        {
            del[] dels =
            {
                new del(CheckSum),
                new del(CheckSub),
                new del(CheckMult)

            };
            foreach (del de in dels)
            {
                Console.WriteLine(de(23,52));
            }

        }
    }
}
