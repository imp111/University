using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    public class MarathonRunner : Runner
    {
        public double MarathonDistance { get; set; }

        public MarathonRunner(double age, double weight, double time, double pace, double heartBeats, double energyLevel, double marathonDistance)
            : base(age, weight, time, pace, heartBeats, energyLevel)
        {
            MarathonDistance = marathonDistance;
        }
       
        public void RunMarathon(double distance)
        {
            double maxDistanceBeforeEating = MaxDistanceBeforeEating();
            double eatingStops = 0; double caloriesSpent;
            if (distance > maxDistanceBeforeEating)
            {
                eatingStops++;
            }
            
            if (eatingStops > 0)
            {
                caloriesSpent = ((Age * 0.2017) + (Weight * 0.2259) + (HeartBeats * 0.6309) - 55.0969) * ((Pace * distance) / 4.184) * eatingStops;
            }
            else
            {
                caloriesSpent = ((Age * 0.2017) + (Weight * 0.2259) + (HeartBeats * 0.6309) - 55.0969) * ((Pace * distance) / 4.184);
            }
            

            Console.WriteLine("The distance {0}km can be completed with {1} kcal burned and the number of stops needed to eat are {2}.", distance, Math.Round(caloriesSpent, 2), eatingStops);
        }
    }
}
