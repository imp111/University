using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_version1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter gender: ");
            string input = Console.ReadLine().ToLower();

            List<Male> maleList = new List<Male>();
            List<Female> femaleList = new List<Female>();
            
            while (input != "end")
            {
                if (input == "male")
                {
                    Male objMale = new Male();

                    string name = objMale.EnterName();
                    int age = objMale.EnterAge();
                    int height = objMale.EnterHeight();

                    Male charSet = new Male(name, age, height);
                    maleList.Add(charSet);

                    Console.Write("Enter running speed: ");
                    int speed = objMale.Run();

                    objMale.Comparisons(speed, height);
                }
                else if (input == "female")
                {
                    Female objFemale = new Female();

                    string name = objFemale.EnterName();
                    int age = objFemale.EnterAge();
                    int height = objFemale.EnterHeight();

                    Female charSet = new Female(name, age, height);
                    femaleList.Add(charSet);

                    Console.Write("Enter running speed: ");
                    int speed = objFemale.Run();

                    objFemale.Comparisons(speed, height);
                }
                else
                {
                    Console.WriteLine("invalid gender, try again!");
                }

                Console.Write("Enter gender (end - to end): ");
                input = Console.ReadLine().ToLower();
            }

            Console.WriteLine();
            foreach (Male item in maleList)
            {
                Console.WriteLine("Competitors: ");
                Console.WriteLine("| Name:{0} | Age:{1} years old | Height:{2} cm. |", item.NameSet, item.AgeSet, item.HeightSet);
            }

            foreach (Female item in femaleList)
            {
                Console.WriteLine("| Name:{0} | Age:{1} years old | Height:{2} cm. |", item.NameSet, item.AgeSet, item.HeightSet);
            }
        }
    }
    
}
