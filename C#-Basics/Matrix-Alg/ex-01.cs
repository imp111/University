using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework01
{
    class homework01
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number of rows: ");
            int lengthI = int.Parse(Console.ReadLine());
            Console.Write("Enter number of colums: ");
            int lengthJ = int.Parse(Console.ReadLine());

            int[,] twoDimensional = new int[lengthI, lengthJ];
            int[] oneDimensional = new int[lengthI * lengthJ];

            int count = 0;
            for (int i = 0; i < lengthI; i++)
            {
                for (int j = 0; j < lengthJ; j++)
                {
                    twoDimensional[i, j] = int.Parse(Console.ReadLine());
                    oneDimensional[count++] = twoDimensional[i, j];
                }
            }

            Console.WriteLine(string.Join(" ", oneDimensional));
        }
    }
}
