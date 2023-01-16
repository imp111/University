using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    public class Runner
    {
        public double Age { get; private set; } // age [n]
        public double Weight { get; private set; } // weight in kg
        public double Pace { get; private set; } // pace per km (average around 9:03 per km)
        public double Time { get; private set; } // time to run the distance
        public double HeartBeats { get; private set; } // per minute
        private EnergyLevels energyLevels; // energy level in [%] (0-100%)

        public Runner(double age, double weight, double pace, double time, double heartBeats, double energyLevel)
        {
            Age = age;
            Weight = weight;
            Time = time;
            Pace = pace;
            HeartBeats = heartBeats;
            energyLevels = new EnergyLevels(100, energyLevel);
        }

        protected double MaxDistanceBeforeEating()
        {
            double maxDistance = HeartBeats * energyLevels.CurrentEnergyLevel;
            return maxDistance;
        }

        public void RunningDistance(double distanceToRun)
        {
            double maxDistanceBeforeEating = MaxDistanceBeforeEating();

            if (maxDistanceBeforeEating > distanceToRun) // the energy we have should all be equal to the distance we can run 
            {
                double energySpent = energyLevels.CurrentEnergyLevel;
                energyLevels.CurrentEnergyLevel -= energySpent;
                Console.WriteLine("Runner ran {0}km. using {1} percentage energy.", distanceToRun, energySpent);
            }
            else
            {
                Console.WriteLine("Runner cant run {0}km. with the current amount of energy, he needs to eat!", distanceToRun);
            }
        }

        public void Eating()
        {
            double energyNeeded = energyLevels.GetMaxEnergyLevel();
            energyLevels.CurrentEnergyLevel = energyLevels.MaxEnergyLevel;
            Console.WriteLine("{0}% is added to runner's energy level", energyNeeded);
        }
    }
}
