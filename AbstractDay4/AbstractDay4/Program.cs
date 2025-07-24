using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDay4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nithin emp1 = new Nithin("Nithin", "Developer", 1000000);
            Nithin emp2 = new Nithin("Uday","HR",150000);
            Nithin emp3= new Nithin("Ram","Sr.Developer",250000);
            Employ[] emp = new Employ[]
            {
               emp1, emp2, emp3
            };

            foreach (var employee in emp)
            {
                Console.WriteLine(employee);
            }
            DataTraining training = new DataTraining();
            training.Name();
            training.Email();
            training.company();
        }
    }
}
