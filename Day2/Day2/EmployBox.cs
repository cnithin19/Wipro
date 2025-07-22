using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class EmployBox
    {
        public void show(object obj)
        {
            string type = obj.GetType().Name;
            Console.WriteLine(type);
            Console.WriteLine(obj);
            if (type.Equals("Employ"))
            {
                Employ employ=(Employ)obj;
                Console.WriteLine("Employ no {0} , Employ name : {1} , Employ Salary : {2} .",employ.empId,
                    employ.empName,employ.empSalary);
            }
        }

        static void Main()
        {
            Employ employ = new Employ();
            employ.empId = 1;
            employ.empName = "John Doe";
            employ.empSalary = 50000;

            EmployBox box = new EmployBox();

            box.show(employ);
        }
    }
}
