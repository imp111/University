using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Задача 3: Запазете няколко стринга въведени от конзолата в масив и съставете изречение, което да се покаже в конзолата.

namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of strings to enter: ");
            int num = int.Parse(Console.ReadLine());

            string[] storage = new string[num];

            for (int i = 0; i < num; i++)
            {
                storage[i] = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", storage));
        }
    }
}
