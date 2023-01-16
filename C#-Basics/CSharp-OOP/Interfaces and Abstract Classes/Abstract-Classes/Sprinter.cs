using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    public enum SprinterSpeeds // km/h
    {
        Slow = 20,
        Average = 25,
        Fast = 30,
    }

    public class Sprinter : Runner
    {
        public override string Type
        {
            get { return "Sprinter"; }
        }

        public override double Speed
        {
            get { return 26; }
        }

        public void CompareSpeed(double speed)
        {
            if (speed >= 20 && speed < 25)
            {
                Console.WriteLine(SprinterSpeeds.Slow);
            }
            else if (speed >= 25 && speed < 30)
            {
                Console.WriteLine(SprinterSpeeds.Average);
            }
            else if (speed >= 30 && speed < 32)
            {
                Console.WriteLine(SprinterSpeeds.Fast);
            }
            else
            {
                Console.WriteLine("Elite sprinter speed, change rank");
            }
        }
    }
}