using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public enum FemaleAverageHeight //centimeters
    {
        Short = 150,
        Average = 170,
        Tall = 190
    }

    public enum FemaleAverageSpeed //seconds
    {
        Slow = 9,
        Average = 8,
        Fast = 7
    }

    internal class Female
    {
        private string gender = "female";
        private string name;
        private int age;
        private int height;

        public string Gender
        {
            get { return gender; }
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (value != "" || value != " ")
                {
                    name = value;
                }
                else
                {
                    int i = 0;
                    i++;
                    name = $"Antonia{i}"; 
                }
            }
        }

        public int Age
        {
            get { return age; }
            private set
            {
                if (value <= 120 && value >= 0)
                {
                    age = value;
                }
                else
                {
                    age = 25;
                }
            }
        }

        public int Height
        {
            get { return height; }
            private set
            {
                if (value <= 200 && value >= 50)
                {
                    height = value;
                }
                else
                {
                    height = 160;
                }
            }
        }

        public static int femaleCounter;

        public Female()
        {
            this.gender = "female";
        }

        public string EnterName()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            return name;
        }
        public int EnterAge()
        {
            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            return age;
        }
        public int EnterHeight()
        {
            Console.Write("Enter Height: ");
            int height = int.Parse(Console.ReadLine());
            femaleCounter++;

            return height;
        }

        public Female(string name, int age, int height)
        {
            this.NameSet = name;
            this.AgeSet = age;
            this.HeightSet = height;
        }

        public FemaleAverageHeight MeassureHeight(int height) // measure current female height
        {
            if (height >= 160 && height <= 170)
            {
                return FemaleAverageHeight.Average;
            }
            else if (height >= 190)
            {
                return FemaleAverageHeight.Tall;
            }
            else
            {
                return FemaleAverageHeight.Short;
            }
        }

        public int Run() // current female running speed
        {
            int runTime = int.Parse(Console.ReadLine());
            return runTime;
        }

        public static void PrintFemaleCount() // number of female competitors 
        {
            Console.WriteLine("Number of female competitors: {0}", femaleCounter);
        }

        public FemaleAverageSpeed MeassureSpeed(int runTime) // measures female average speed
        {
            if (runTime == 8) 
            {
                return FemaleAverageSpeed.Average;
            }
            else if (runTime >= 9)
            {
                return FemaleAverageSpeed.Slow;
            }
            else
            {
                return FemaleAverageSpeed.Fast;
            }
        }

        public void Comparisons(int speed, int height) // measures current female stats (height, running speed)
        {
            Console.Write("Enter measurement | Height | Running speed | end |: ");
            string measurementChoice = Console.ReadLine().ToLower();

            while (measurementChoice != "end")
            {
                if (measurementChoice == "height")
                {
                    Console.WriteLine(MeassureHeight(height)); // measure height
                }
                else if (measurementChoice == "running speed")
                {
                    Console.WriteLine(MeassureSpeed(speed)); // measure speed
                }
                else
                {
                    Console.WriteLine("invalid measurement"); // invalid choice
                }

                Console.Write("Enter measurement | Height | Running speed | end |: ");
                measurementChoice = Console.ReadLine().ToLower();
            }
        }

        public class TopFemale 
        {
            public static void PrintBestTime(string name, int time)
            {
                Console.WriteLine("{0}'s time: {1} seconds.", name, time); // print current female competitor
            }
        }
    }
}
