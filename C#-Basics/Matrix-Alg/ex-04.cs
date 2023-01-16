using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_04
{
    class Program
    {
        public static void addition(double[,] A, double[,] B, double[,] C, int I, int J)
        {
            for (int i = 0; i < I; i++)
            {
                for (int j = 0; j < J; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }

            int lineBreak = 0;
            foreach (int n in C)
            {
                lineBreak++;
                Console.Write(n + " ");
                if (lineBreak == J)
                {
                    lineBreak = 0;
                    Console.WriteLine();
                }
            }
        }

        public static void substraction(double[,] A, double[,] B, double[,] C, int I, int J)
        {
            for (int i = 0; i < I; i++)
            {
                for (int j = 0; j < J; j++)
                {
                    C[i, j] = A[i, j] - B[i, j];
                }
            }

            int lineBreak = 0;
            foreach (int n in C)
            {
                lineBreak++;
                Console.Write(n + " ");
                if (lineBreak == J)
                {
                    lineBreak = 0;
                    Console.WriteLine();
                }
            }
        }

        public static void multiplication(double[,] A, double[,] B, double[,] C, int I, int J)
        {
            for (int i = 0; i < I; i++)
            {
                for (int j = 0; j < J; j++)
                {
                    C[i, j] = A[i, j] * B[i, j];
                }
            }

            int lineBreak = 0;
            foreach (int n in C)
            {
                lineBreak++;
                Console.Write(n + " ");
                if (lineBreak == J)
                {
                    lineBreak = 0;
                    Console.WriteLine();
                }
            }
        }

        
        static void Main(string[] args)
        {
            Console.Write("Enter rows length: ");
            int lengthI = int.Parse(Console.ReadLine());

            Console.Write("Enter columns length: ");
            int lengthJ = int.Parse(Console.ReadLine());

            double[,] A = new double[lengthI, lengthJ];
            double[,] B = new double[lengthI, lengthJ];
            double[,] C = new double[lengthI, lengthJ];

            Console.WriteLine("Enter first matrix (A):");
            for (int i = 0; i < lengthI; i++)
            {
                for (int j = 0; j < lengthJ; j++)
                {
                    A[i, j] = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter second matrix (B):");
            for (int i = 0; i < lengthI; i++)
            {
                for (int j = 0; j < lengthJ; j++)
                {
                    B[i, j] = double.Parse(Console.ReadLine());
                }
            }

            Console.Write("Choose operation: ");
            string choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "addition":
                    addition(A, B, C, lengthI, lengthJ);
                    break;

                case "substraction":
                    substraction(A, B, C, lengthI, lengthJ);
                    break;

                case "multiplication":
                    multiplication(A, B, C, lengthI, lengthJ);
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
