using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning2
{
    class homework06
    {
        public static int[,] valueAssign(int[,] array, int lengthI, int lengthJ)
        {
            Random random = new Random();
            for (int i = 0; i < lengthJ; i++)
            {
                for (int j = 0; j < lengthJ; j++)
                {
                    array[i, j] = random.Next(0, 10);
                }
            }

            return array;
        }

        public static void printArray(int[,] array, int lengthI, int lengthJ)
        {
            int lineBreak = 0;
            for (int i = 0; i < lengthI; i++)
            {
                for (int j = 0; j < lengthJ; j++)
                {
                    lineBreak++;
                    if (i <= j)
                    {
                        Console.Write("{0} ", array[i, j]);
                    }
                    else
                    {
                        Console.Write("{0} ", 0);
                    }

                    if (lengthJ == lineBreak)
                    {
                        lineBreak = 0;
                        Console.WriteLine();
                    }
                }
            }
        }
        
        public static void sum(int[,] array, int lengthI, int lengthJ)
        {
            int sum = 1;
            Console.Write("Sum: ");
            for (int i = 0; i < lengthI; i++)
            {
                for (int j = 0; j < lengthJ; j++)
                {
                    if (i == j)
                    {
                        sum *= array[i, j];
                    }
                }
            }

            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows: ");
            int lengthI = int.Parse(Console.ReadLine());
            Console.Write("Enter number of columns: ");
            int lengthJ = int.Parse(Console.ReadLine());

            int[,] array = new int[lengthI, lengthJ];

            valueAssign(array, lengthI, lengthJ);

            printArray(array, lengthI, lengthJ);

            sum(array, lengthI, lengthJ);
        }
    }
}
