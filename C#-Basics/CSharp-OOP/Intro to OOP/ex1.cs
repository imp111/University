using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Задача 2: Напишете програма, която сумира числата от 1 до 100 и ги принтира в конзолата.

namespace exercise2
{
    class Program
    {
        public static int Calculation(int output)
        {
            for (int i = 1; i <= 100; i++)
            {
                output = output + i;
            }

            return output;
        }

        static void Main(string[] args)
        {
            int sum = 0;

            Console.WriteLine("Sum is: {0}", Calculation(sum));
        }
    }
}
