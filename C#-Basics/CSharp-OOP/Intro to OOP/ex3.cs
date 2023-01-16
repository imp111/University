using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Задача 4: Въведете първоначално зададен набор от числа от конзолата, извадете последователно от всички 1 и покажете техния сбор.

namespace exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of ints: ");
            int numberOfInts = int.Parse(Console.ReadLine());
            int output = 0;

            int[] storage = new int[numberOfInts];

            for (int i = 0; i < numberOfInts; i++)
            {
                Console.Write("Enter number {0}: ", i + 1);
                storage[i] = int.Parse(Console.ReadLine());
                storage[i]--;
                output += storage[i];
            }

            Console.WriteLine("Sum is {0}", output);
        }
    }
}
