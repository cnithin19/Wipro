using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class EmployData
    {
        static void Main()
        {
            Employ emp1 = new Employ();
            Employ emp2 = new Employ();
            emp1.name = "nithin";
            emp1.no = 1;
            emp1.salary = 1000000;
            emp2.name="varun";
            emp2.no = 2;    
            emp2.salary = 200000;
            Console.WriteLine("EMP1 name: {0} -> no : {1}->salary : {2}", emp1.name, emp1.no, emp1.salary);
            Console.WriteLine("EMP2 name: {0} -> no : {1}->salary : {2}", emp2.name, emp2.no, emp2.salary);
        }
    }
}
