using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkZadacha7
{
    class homework07
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows: ");
            int lengthI = int.Parse(Console.ReadLine());
            Console.Write("Enter number of columns: ");
            int lengthJ = int.Parse(Console.ReadLine());
 
            int[,] array = new int[lengthI, lengthJ];

            for (int i = 0; i < lengthI; i++)
            {
                for (int j = 0; j < lengthJ; j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int[] forward = new int[9];
            int[] backward = new int[9];

            
            for (int i = 0; i < lengthI; i++)
            {
                for (int j = 0; j < lengthJ; j++)
                {
                    if (i == j)
                    {
                        forward[i] = array[i, j];
                    }
                    else if (i + 1 == j)
                    {
                        if (i + 1 > lengthJ)
                        {
                            forward[i + 3] = array[i, j-j];
                        }
                        else
                        {
                            forward[i + 3] = array[i, j];
                        }
                    }
                    else
                    {
                        forward[i + 6] = array[i, j];
                    }
                }
            }

            

            Console.WriteLine(string.Join(" ", forward));
           
            int lineBreak = 0;
            Console.WriteLine("Δ: ");
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
        }
    }
}
