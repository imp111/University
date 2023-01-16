using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_02
{
    class homework02
    {
        public static void Main(string[] args)
        {
            int lengthI = int.Parse(Console.ReadLine()); // number of rows
            int lengthJ = int.Parse(Console.ReadLine()); // number of columns

            int[,] twoDimensional = new int[lengthI, lengthJ];
            int countI = 1; int countJ = 1;

            // assign values to rows (i)
            for (int i = 0; i < lengthI; i++)
            {
                twoDimensional[i, 0] = countI++;
            }
            // assign values to columns (j)
            for (int j = 0; j < lengthJ; j++)
            {
                twoDimensional[0, j] = countJ++;
            }

            // calculatons
            for (int i = 1; i < lengthI; i++)
            {
                for (int j = 1; j < lengthJ; j++)
                {
                    twoDimensional[i, j] = twoDimensional[0, j] * twoDimensional[i, 0];
                }
            }

            // result
            int lineBreak = 0;
            foreach (int n in twoDimensional)
            {
                lineBreak++;
                Console.Write(n + " ");

                if (lineBreak == lengthJ)
                {
                    lineBreak = 0;
                    Console.WriteLine();
                }
            }
        }
    }
}
