using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Runner");
            List<string> key = new List<string>(6) {"Age [n]", "Weight [kg]", "Pace [min per km]", "Time [min]", "Heart Beat [beats per min]", "Energy Level [0-100%]" };
            List<double> value = new List<double>(key.Count);

            for (int i = 0; i < key.Count; i++)
            {
                Console.Write("Enter {0}: ", key[i]);
                value.Add(double.Parse(Console.ReadLine()));
            }

            Runner firstPerson = new Runner(value[0], value[1], value[2], value[3], value[4], value[5]);

            object myObject = firstPerson;

            try
            {
                Runner newPerson = (Runner)myObject;
            }
            catch (InvalidCastException error)
            {
                throw error;
            }

            Console.WriteLine("Marathon Runner");
            Console.Write("Enter distance [distance the runner can complete]: ");
            value.Add(double.Parse(Console.ReadLine()));

            key.Add("Marathon distance [km]");
            Console.Write("Enter {0}: ", key[6]);
            value.Add(double.Parse(Console.ReadLine()));

            MarathonRunner firstMarathon = new MarathonRunner(value[0], value[1], value[2], value[3], value[4], value[5], value[6]);
            firstMarathon.Eating();
            firstMarathon.RunningDistance(value[6]);
            firstMarathon.RunMarathon(value[7]);


            Console.WriteLine("Sprint Runner");
            key.Add("Max Speed [km/h]");
            Console.Write("Enter {0}: ", key[7]);
            value.Add(double.Parse(Console.ReadLine()));
            SprintRunner firstSprinter = new SprintRunner(value[0], value[1], value[2], value[3], value[4], value[5], value[6], value[8]);
            firstSprinter.Eating();
            Console.Write("Enter lap distance [meters]: ");
            value.Add(double.Parse(Console.ReadLine()));
            Console.Write("Enter number of laps [n]: ");
            value.Add(double.Parse(Console.ReadLine()));
            firstSprinter.Eating();
            firstSprinter.RunSprint(firstSprinter.RunningLaps(value[9], value[10]), value[9]);
        }
    }
}
