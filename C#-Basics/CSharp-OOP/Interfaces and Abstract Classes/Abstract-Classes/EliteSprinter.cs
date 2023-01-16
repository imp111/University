using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    public enum EliteSprinterSpeeds // km/h
    {
        Slow = 30,
        Average = 35,
        Fast = 40,
    }

    internal class EliteSprinter : EliteRunner
    {
        public override string Type { get { return "Elite Sprinter"; } }
        public override double Speed { get { return 38; } }
        public override int Expirience { get { return 12; } }

        public void CompareSpeed(double speed)
        {
            if (speed >= 30 && speed < 35)
            {
                Console.WriteLine(EliteSprinterSpeeds.Slow);
            }
            else if (speed >= 35 && speed < 40)
            {
                Console.WriteLine(EliteSprinterSpeeds.Average);
            }
            else if (speed >= 40 && speed < 46)
            {
                Console.WriteLine(EliteSprinterSpeeds.Fast);
            }
            else
            {
                Console.WriteLine($"New world record {this.Speed}");
            }
        }
    }
}