using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    class EnergyLevels
    {
        public double CurrentEnergyLevel { get; set; }
        public double MaxEnergyLevel { get; set; }

        public EnergyLevels(double maxEnergyLevel, double currentEnergyLevel)
        {
            MaxEnergyLevel = maxEnergyLevel; // by default is 100%
            CurrentEnergyLevel = currentEnergyLevel;
        }

        public double GetMaxEnergyLevel()
        {
            return MaxEnergyLevel - CurrentEnergyLevel; // returns the amount of energy needed to get to 100%
        }
    }
}
