using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Задача 6: Да се напише метод, който получава число и изписва NxN матрица с това число.

namespace exercise6
{
    class Program
    {
        
        public static void Matrix(int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    Console.Write(num + " ");

                    if (j == num - 1)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            Matrix(number);
        }
    }
}
