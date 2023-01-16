using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_version1
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
        private string Gender;
        private string Name;
        private int Age;
        private int Height;

        public string GenderSet
        {
            get { return Gender; }
            set { Gender = "male"; }
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
                    Name = $"Antonio{i}";
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
                    Age = 30;
                }
            }
        }

        public int HeightSet
        {
            get { return Height; }
            set
            {
                if (value <= 270 && value >= 70)
                {
                    Height = value;
                }
                else
                {
                    Height = 170;
                }
            }
        }

        public Male()
        {
            this.Gender = "male";
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

        public Male(string name, int age, int height)
        {
            this.NameSet = name;
            this.AgeSet = age;
            this.HeightSet = height;
        }

        public MaleAverageHeight MeassureHeight(int height)
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

        public int Run()
        {
            int runTime = int.Parse(Console.ReadLine());
            return runTime;
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
    }
}
