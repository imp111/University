using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    public enum EliteMarathonSpeed
    {
        Slow = 7,
        Average = 10,
        Fast = 15
    }

    public enum EliteMarathonDistance // km
    {
        Short = 10,
        Average = 30,
        Long = 60
    }

    public class EliteMarathon : EliteRunner
    {
        public override string Type { get { return "Elite Marathon Runner"; } }
        public override double Speed { get { return 12; } }
        public override int Expirience { get { return 10; } }

        public void CompareSpeed(double speed)
        {
            if (speed >= 7 && speed < 10)
            {
                Console.WriteLine(EliteMarathonSpeed.Slow);
            }
            else if (speed >= 10 && speed < 15)
            {
                Console.WriteLine(EliteMarathonSpeed.Average);
            }
            else if (speed >= 15 && speed < 25)
            {
                Console.WriteLine(EliteMarathonSpeed.Fast);
            }
            else
            {
                Console.WriteLine($"New world record {this.Speed}");
            }
        }

        public void CompareDistance(double distance)
        {
            if (distance >= 10 && distance < 30)
            {
                Console.WriteLine(EliteMarathonDistance.Short);
            }
            else if (distance >= 30 && distance < 60)
            {
                Console.WriteLine(EliteMarathonDistance.Average);
            }
            else if (distance >= 60 && distance < 200)
            {
                Console.WriteLine(EliteMarathonDistance.Long);
            }
        }
    }
}