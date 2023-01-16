using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    public abstract class EliteRunner : Runner
    {
        public abstract int Expirience { get; }

        public virtual void EliteCheck(int years)
        {
            if (years > 7)
            {
                Console.WriteLine($"This athlete is an elite |{this.Type}| runner");
            }
            else
            {
                Console.WriteLine($"This athlete is an average |{this.Type}| runner");
            }
        }
    }
}