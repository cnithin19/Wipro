using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDay4
{
    internal abstract class Training
    {
        public void company()
        {
            Console.WriteLine("You are a Wipro Member .");
        }
        public abstract void Name();
        public abstract void Email();

    }
}
