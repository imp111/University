using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    class SprintRunner : MarathonRunner
    {
        public double MaxSpeed { get; set; }
        public SprintRunner(double age, double weight, double time, double pace, double heartBeats, double energyLevel, double marathonDistance, double maxSpeed)
            :base(age, weight, time, pace, heartBeats, energyLevel, marathonDistance)
        {
            MaxSpeed = maxSpeed;
        }

        public double RunningLaps(double lapDistance, double laps)
        {
            double distance = laps * lapDistance;

            return distance;
        }

        public void RunSprint(double distance, double lapDistance)
        {
            double caloriesSpent = ((Age * 0.2017) + (Weight * 0.2259) + (HeartBeats * 0.6309) - 55.0969) * ((Pace * (lapDistance / 1000)) / 4.184);
            
            Console.WriteLine("The distance {0}meters can be completed with {1} kcal burned.", distance, Math.Round(caloriesSpent, 2));
        }
    }
}
