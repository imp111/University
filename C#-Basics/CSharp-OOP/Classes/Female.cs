using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_version1
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
        private string Gender;
        private string Name;
        private int Age;
        private int Height;

        public string GenderSet
        {
            get { return Gender; }
            set { Gender = "female"; }
        }

        public string NameSet
        {
            get { return Name; }
            set
            {
                if (value != "" || value != " ")
                {
                    Name = value;
                }
                else
                {
                    int i = 1;
                    Name = $"Antonia{i}";
                    i++;
                }
            }
        }

        public int AgeSet
        {
            get { return Age; }
            set
            {
                if (value <= 120 && value >= 0)
                {
                    Age = value;
                }
                else
                {
                    Age = 25;
                }
            }
        }

        public int HeightSet
        {
            get { return Height; }
            set
            {
                if (value <= 200 && value >= 50)
                {
                    Height = value;
                }
                else
                {
                    Height = 160;
                }
            }
        }

        public Female()
        {
            this.GenderSet = "female";
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

            return height;
        }

        public Female(string name, int age, int height)
        {
            this.NameSet = name;
            this.AgeSet = age;
            this.HeightSet = height;
        }

        public FemaleAverageHeight MeassureHeight(int height)
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

        public int Run()
        {
            int runTime = int.Parse(Console.ReadLine());
            return runTime;
        }

        public FemaleAverageSpeed MeassureSpeed(int runTime)
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

        public void Comparisons(int speed, int height)
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

        class TopFemale
        {
        }
    }
}
