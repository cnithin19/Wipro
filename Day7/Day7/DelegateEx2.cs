using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{

    internal class DelegateEx2
    {
        public delegate void Delegate(int n);

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
        public static string CheckSum(int n,int m)
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
            Action act = action;
            act();

            Func<int, string> obj = Check;
            Console.WriteLine(obj(-25)); 
            Func<int,int,string> obj2 = CheckSum;
            obj2 += CheckSub;
            obj2 += CheckMult;
            foreach (Func<int,int, string> f in obj2.GetInvocationList())
            {
                Console.WriteLine(f(5, 8));
            }
            Predicate<int> vote = VoteEligible;
            Console.WriteLine("Enter age to check vote eligible :");
            int age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(vote(age)); 
        }
    }
}
