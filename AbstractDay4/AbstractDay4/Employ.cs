using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDay4
{
    internal abstract class Employ
    {
        protected string Name { get; set; }
        protected string Role { get; set; }
        protected int Salary { get; set; }

        public Employ(string name, string role, int salary)
        {
            Name = name;
            Role = role;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Emp name: {Name} Role is : {Role} Salary is : {Salary}";
        }
    }
}
