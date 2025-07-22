using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    /// <summary>
    /// voting eligibility check based on age.
    /// </summary>
    internal class Voting
    {
        public void CheckEligibility(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote.");
            }
        }

        static void Main()
        {
            Console.WriteLine("Enter your age : ");
            int age=Convert.ToInt32(Console.ReadLine());
            Voting voting = new Voting();
            voting.CheckEligibility(age);
        }
    }
}
