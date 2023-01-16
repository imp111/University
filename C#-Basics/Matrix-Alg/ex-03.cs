using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkZad3
{
    class homework03
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("Enter number of rows: ");
            int lengthI = int.Parse(Console.ReadLine());
            Console.Write("Enter number of columns: ");
            int lengthJ = int.Parse(Console.ReadLine());

            int[,] array = new int[lengthI, lengthJ];

            for (int i = 0; i < lengthI; i++)
            {
                for (int j = 0; j < lengthJ; j++)
                {
                    //array[i, j] = random.Next(0, 2);
                    Console.Write("Enter row {0} and column {1} element: " , i, j);
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int lineBreak = 0;
            foreach (int n in array)
            {
                lineBreak++;
                Console.Write(n + " ");

                if (lengthJ == lineBreak)
                {
                    lineBreak = 0;
                    Console.WriteLine();
                }
            }

            int countDown = 0;
            int countUp = 0;
            int countMiddle = 0;

            for (int i = 0; i < lengthI; i++)
            {
                for (int j = 0; j < lengthJ; j++)
                {
                    if (i < j)
                    {
                        if (array[i,j] == 0)
                        {
                            countUp++;
                        }
                    }
                    else if (i > j)
                    {
                        if (array[i,j] == 0)
                        {
                            countDown++;
                        }
                    }
                    else
                    {
                        if(array[i,j] != 0)
                        {
                            countMiddle++;
                        }
                    }
                }
            }

            if (countMiddle == 3 && countDown == 3 && countUp == 3)
            {
                Console.WriteLine("Triangle");
            }
            else
            {
                Console.WriteLine("Not triangle");
            }  
        }
    }
}
