using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class ArrayForWhile
    {
        public void sum(int[] n)
        {
            int sum = 0;
            for (int i = 0; i< n.Length; i++)
            {
                sum += n[i];
                
            }
            Console.WriteLine("sum is :"+sum);
        }
        public void Palindrome(string s)
        {
            char[] c = s.ToCharArray();
            string rev = "";
            for(int i = s.Length - 1; i >= 0; i--)
            {
                rev += c[i];
            }
            Console.WriteLine("Palindrome is :"+rev.Equals(s));
            
        }
        public void Factorial(int n)
        {
            int fact = 1;
            while (n != 0)
            {
                fact *= n;
                n--;
            }
            Console.WriteLine("This is your Factorial :"+fact);
        }
        public void PerfectNumber(int n)
        {
            int sum = 0;
            for(int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }

            }
            if(sum==n) Console.WriteLine("This {0} is Perfect Number .",n);
            else Console.WriteLine("not a perfect number ");
        }
        public void SentencePalindrome(string s)
        {
            int count = 0;
            string sss = "";
            string[] str = s.Split(' ');
            for(int i=0;i<str.Length; i++)
            {
               // Console.WriteLine(str[i]);
                char[] c = str[i].ToCharArray();
                string rev = "";
                for (int j = c.Length - 1; j >= 0; j--)
                {
                    rev += c[j];
                }
                if (rev.Equals(str[i]))
                {
                    sss+= str[i] +" ";
                    count++;
                }

            }
            Console.WriteLine("Palindrome count is : "+count + " . They are : "+sss);

        }

        static void Main()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5 };
            //string str = "hello world ! This is C#";
            Console.WriteLine("Enter word to check Palindrome :");
            string str = Console.ReadLine();
            ArrayForWhile test = new ArrayForWhile();
            test.sum( a );
            test.Palindrome(str);
            Console.WriteLine("give number to find Factorial : ");
            int n = Convert.ToInt32(Console.ReadLine());
            test.Factorial(n);
            Console.WriteLine("Is given Number is perfect number or not , Enter a number :");
            int x= Convert.ToInt32(Console.ReadLine());
            test.PerfectNumber(x);
            Console.WriteLine("Enter sentence and find out number of palindromes :");
            string y = Console.ReadLine();
            test.SentencePalindrome(y);
        }
    }
}
