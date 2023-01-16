using System;


namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("Enter number of rows: ");
            int lengthI = int.Parse(Console.ReadLine()) + 2;
            Console.Write("Enter number of columns: ");
            int lengthJ = int.Parse(Console.ReadLine()) + 2;

            int[,] oldArray = new int[lengthI, lengthJ];
            int[,] newArray = new int[lengthI, lengthJ];

            /* Assign inner layer (oldArray) */
            for (int i = 1; i < lengthI - 1; i++) 
            {
                for (int j = 1; j < lengthJ - 1 ; j++)
                {
                    oldArray[i, j] = random.Next(0, 2);
                }
            }

            /*   Assign first row (oldArray)   */
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < lengthJ; j++)
                {
                    if (j == 0)
                    {
                        oldArray[i, j] = oldArray[lengthI - 2, lengthJ - 2 ];
                    }
                    else if (j == lengthJ - 1)
                    {
                        oldArray[i, j] = oldArray[lengthI - 2, 1];
                    }
                    else
                    {
                        oldArray[i, j] = oldArray[lengthI - 2, j];
                    } 
                }
            }

            /* Assign mid section (oldArray) */
            for (int i = 1; i < lengthI - 1; i++)
            {
                for (int j = 0; j < lengthJ; j += (lengthJ - 1))
                {
                    if (j == 0)
                    {
                        oldArray[i, j] = oldArray[i , lengthJ - 2];
                    }
                    else
                    {
                        oldArray[i, j] = oldArray[i, 1];
                    }                  
                }
            }
            
            /* Assign last row (oldArray */
            for (int i = lengthI; i < lengthI + 1; i++)
            {
                for (int j = 0; j < lengthJ; j++)
                {
                    if (j == 0)
                    {
                        oldArray[i - 1, j] = oldArray[1, lengthJ - 2];
                    }
                    else if (j == lengthJ - 1)
                    {
                        oldArray[i - 1, j] = oldArray[1, 1];
                    }
                    else
                    {
                        oldArray[i - 1, j] = oldArray[1, j];
                    }
                }
            }

            /* Check neighbours */
            for (int i = 1; i < lengthJ - 2; i++)
            {
                for (int j = 1; j < lengthI - 2; j++)
                {
                    int count = 0;

                    if (oldArray[i - 1, j - 1] == 1) // up left
                    {
                        count += 1;
                    }

                    if (oldArray[i - 1, j] == 1) // up
                    {
                        count += 1;
                    }

                    if (oldArray[i - 1, j + 1] == 1) // up right
                    {
                        count += 1;
                    }

                    if (oldArray[i, j - 1] == 1) // left
                    {
                        count += 1;
                    }

                    if (oldArray[i, j + 1] == 1) // right
                    {
                        count += 1;
                    }

                    if (oldArray[i + 1, j - 1] == 1) // down left
                    {
                        count += 1;
                    }

                    if (oldArray[i + 1, j] == 1) // down
                    {
                        count += 1;
                    }

                    if (oldArray[i + 1, j + 1] == 1) // down right
                    {
                        count += 1;
                    }

                    /* Assign newArray */
                    if (oldArray[i, j] == 1) // rules
                    {
                        if (count == 2 || count == 3)
                        {
                            newArray[i, j] = 1;
                        }
                        else
                        {
                            newArray[i, j] = 0;
                        }
                    }
                    else
                    {
                        if (count == 3)
                        {
                            newArray[i, j] = 1;
                        }
                        else
                        {
                            newArray[i, j] = 0;
                        }
                    }
                }
            }


            /* Print oldArray */
            int lineBreak = 1; 
            for (int i = 1; i < lengthI - 1; i++)
            {
                for (int j = 1; j < lengthJ - 1; j++)
                {
                    lineBreak++;
                    Console.Write(oldArray[i, j] + " ");

                    if (lengthJ - 1 == lineBreak)
                    {
                        lineBreak = 1;
                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine();

            
            /* Print newArray */
            lineBreak = 1; 
            for (int i = 1; i < lengthI - 1; i++)
            {
                for (int j = 1; j < lengthJ - 1; j++)
                {
                    lineBreak++;
                    Console.Write(newArray[i, j] + " ");

                    if (lengthJ - 1 == lineBreak)
                    {
                        lineBreak = 1;
                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
