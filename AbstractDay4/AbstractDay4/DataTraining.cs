using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDay4
{
    internal class DataTraining : Training
    {
        public override void Email()
        {
            Console.WriteLine("This  email is help for wipro Training members : wipro@training.com ");
        }

        public override void Name()
        {
            Console.WriteLine("Trainer name is Ram");
        }
    }
}
