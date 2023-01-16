using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    public class Program
    {
        public static void CompareRunners(Runner first, Runner second)
        {
            if (first.CompareTo(second) > 0)
            {
                Console.WriteLine($"{first.Type} is faster than {second.Type}");
            }
            else if (first.CompareTo(second) == 0)
            {
                Console.WriteLine($"{first.Type} and {second.Type} are equal");
            }
            else
            {
                Console.WriteLine($"{second.Type} is faster than {first.Type}");
            }
        }

        private static void Main(string[] args)
        {
            List<Runner> athletes = new List<Runner>();

            EliteSprinter eliteSprinter1 = new EliteSprinter();
            Console.WriteLine($"Type: {eliteSprinter1.Type}, Speed: {eliteSprinter1.Speed}km/h, Expirience: {eliteSprinter1.Expirience}");
            Console.Write("World top chart speed comparison: ");
            eliteSprinter1.CompareSpeed(eliteSprinter1.Speed);
            eliteSprinter1.EliteCheck(eliteSprinter1.Expirience);
            athletes.Add(eliteSprinter1);

            Console.WriteLine();

            EliteMarathon eliteMarathon1 = new EliteMarathon();
            Console.WriteLine($"Type: {eliteMarathon1.Type}, Speed: {eliteMarathon1.Speed}km/h, Expirience: {eliteMarathon1.Expirience}");
            Console.Write("World top chart speed comparison: ");
            eliteMarathon1.CompareSpeed(eliteMarathon1.Speed);
            Console.Write("World top chart distance comparison: ");
            eliteMarathon1.CompareDistance(100);
            Console.Write("Exprience: ");
            eliteMarathon1.EliteCheck(eliteMarathon1.Expirience);
            athletes.Add(eliteMarathon1);

            Console.WriteLine();

            Sprinter sprinter1 = new Sprinter();
            Console.WriteLine($"Type: {sprinter1.Type}, Speed: {sprinter1.Speed}km/h");
            Console.Write("World top chart speed comparison: ");
            sprinter1.CompareSpeed(sprinter1.Speed);
            athletes.Add(sprinter1);

            Console.WriteLine();

            Marathon marathon1 = new Marathon();
            Console.WriteLine($"Type: {marathon1.Type}, Speed: {marathon1.Speed}km/h.");
            Console.Write("World top chart speed comparison: ");
            marathon1.CompareSpeed(marathon1.Speed);
            marathon1.CompareDistance(50);
            athletes.Add(marathon1);

            Console.WriteLine();

            CompareRunners(eliteMarathon1, marathon1);
            CompareRunners(eliteSprinter1, sprinter1);

            Console.WriteLine();

            Console.WriteLine("List of athletes: ");
            foreach (Runner var in athletes)
            {
                Console.WriteLine($"Type: {var.Type} | Speed: {var.Speed}km/h.");
            }
        }
    }
}