using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class CaseEx
    {
        public void DisplayChoice(char choice)
        {
            switch (choice)
            {
                case 'a':
                case '1':
                case 'A':
                    Console.WriteLine("You chose option A.");
                    break;
                case 'b':
                case '2':
                case 'B':
                    Console.WriteLine("You chose option B.");
                    break;
                case 'C':
                    Console.WriteLine("You chose option C.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose A, B, or C.");
                    break;
            }
        }
       

        static void Main()
        {
            Console.WriteLine("Enter a choice :");
            char choice = Convert.ToChar(Console.ReadLine());
            CaseEx caseex=new CaseEx();
            caseex.DisplayChoice(choice);

        }
    }
}
