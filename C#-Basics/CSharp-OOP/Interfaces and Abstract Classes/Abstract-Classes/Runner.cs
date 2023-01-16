using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    public abstract class Runner : IComparable<Runner>
    {
        public abstract string Type { get; }
        public abstract double Speed { get; }

        public int CompareTo(Runner other)
        {
            return this.Speed.CompareTo(other.Speed);
        }

        public override string ToString()
        {
            return "Type: " + this.Type;
        }
    }
}