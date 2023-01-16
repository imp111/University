using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    public enum MarathonSpeed
    {
        Slow = 5,
        Average = 7,
        Fast = 10
    }

    public enum MarathonDistance
    {
        Short = 5,
        Average = 10,
        Long = 20
    }

    public class Marathon : Runner
    {
        public override string Type
        {
            get { return "Marathon runner"; }
        }

        public override double Speed
        {
            get { return 10; }
        }

        public void CompareSpeed(double speed)
        {
            if (speed >= 5 && speed < 7)
            {
                Console.WriteLine(MarathonSpeed.Slow);
            }
            else if (speed >= 7 && speed < 10)
            {
                Console.WriteLine(MarathonSpeed.Average);
            }
            else if (speed >= 10 && speed < 15)
            {
                Console.WriteLine(MarathonSpeed.Fast);
            }
            else
            {
                Console.WriteLine("Elite marathon runner speed, change rank");
            }
        }

        public void CompareDistance(double distance)
        {
            if (distance >= 5 && distance < 10)
            {
                Console.WriteLine(EliteMarathonDistance.Short);
            }
            else if (distance >= 10 && distance < 20)
            {
                Console.WriteLine(EliteMarathonDistance.Average);
            }
            else if (distance >= 20 && distance < 50)
            {
                Console.WriteLine(EliteMarathonDistance.Long);
            }
        }
    }
}