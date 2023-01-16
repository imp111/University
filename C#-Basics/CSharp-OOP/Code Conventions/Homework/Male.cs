using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public enum MaleAverageHeight //centimeters
    {
        Short = 170,
        Average = 180,
        Tall = 190
    }

    public enum MaleAverageSpeed //seconds
    {
        Slow = 8,
        Average = 7,
        Fast = 6
    }

    public class Male
    {
        private string gender = "male";
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
                    name = $"Antonio{i}";
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
                    age = 30;
                }
            }
        }

        public int Height
        {
            get { return height; }
            private set
            {
                if (value <= 270 && value >= 70)
                {
                    height = value;
                }
                else
                {
                    height = 170;
                }
            }
        }

        public static int maleCounter;

        public Male()
        {
            this.gender = "male";
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
            maleCounter++;

            return height;
        }

        public Male(string name, int age, int height)
        {
            this.NameSet = name;
            this.AgeSet = age;
            this.HeightSet = height;
        }

        public MaleAverageHeight MeassureHeight(int height) // measure male average height
        {
            if (height >= 160 && height <= 170)
            {
                return MaleAverageHeight.Average;
            }
            else if (height >= 190)
            {
                return MaleAverageHeight.Tall;
            }
            else
            {
                return MaleAverageHeight.Short;
            }
        }

        public int Run()  // measures male average speed
        {
            int runTime = int.Parse(Console.ReadLine());
            return runTime;
        }

        public static void PrintMaleCount()  // number of male competitors 
        {
            Console.WriteLine("Number of male competitors: {0}", maleCounter);
        }

        public MaleAverageSpeed MeassureSpeed(int runTime) 
        {
            if (runTime == 8)
            {
                return MaleAverageSpeed.Average;
            }
            else if (runTime >= 9)
            {
                return MaleAverageSpeed.Slow;
            }
            else
            {
                return MaleAverageSpeed.Fast;
            }
        }

        public void Comparisons(int speed, int height) // measures current male stats (height, running speed)
        {
            Console.Write("Enter measurement | Height | Running speed | end |: ");
            string measurementChoice = Console.ReadLine().ToLower();

            while (measurementChoice != "end")
            {
                if (measurementChoice == "height")
                {
                    Console.WriteLine(MeassureHeight(height));
                }
                else if (measurementChoice == "running speed")
                {
                    Console.WriteLine(MeassureSpeed(speed));
                } 
                else
                {
                    Console.WriteLine("invalid measurement");
                }

                Console.Write("Enter measurement | Height | Running speed | end |: ");
                measurementChoice = Console.ReadLine().ToLower();
            }
        }

        public class TopMale
        {
            public static void PrintBestTime(string name, int time)
            {
                Console.WriteLine("{0}'s time: {1} seconds.", name, time); // print current male competitor speed and name
            }
        }
    }
}
