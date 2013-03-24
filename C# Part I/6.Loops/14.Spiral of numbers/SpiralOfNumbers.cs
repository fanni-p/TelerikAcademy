using System;

namespace _14.Spiral_of_numbers
{
    class SpiralOfNumbers
    {
        static void Main()
        {
            Console.Write("Enter N (N<20) = ");
            int n = int.Parse(Console.ReadLine());
            int col = 0, row = 0;
            int colMax = n - 1, colMin = 0;
            int rowMax = n - 1, rowMin = 1;
            int count = 1;
            int[,] array = new int[n, n];
            if (n >= 0 && n < 20)
            {
                do
                {
                    while (col <= colMax)
                    {
                        if (col == colMax)
                        {
                            colMax = colMax - 1;
                            array[row, col] = count;
                            count++;
                            break;
                        }
                        array[row, col] = count;
                        col++;
                        count++;
                    }
                    row++;
                    while (row <= rowMax)
                    {
                        if (row == rowMax)
                        {
                            rowMax = rowMax - 1;
                            array[row, col] = count;
                            count++;
                            break;
                        }
                        array[row, col] = count;
                        row++;
                        count++;
                    }
                    col--;
                    while (col >= colMin)
                    {
                        if (col == colMin)
                        {
                            colMin = colMin + 1;
                            array[row, col] = count;
                            count++;
                            break;
                        }
                        array[row, col] = count;
                        col--;
                        count++;
                    }
                    row--;
                    while (row >= rowMin)
                    {
                        if (row == rowMin)
                        {
                            rowMin = rowMin + 1;
                            array[row, col] = count;
                            count++;
                            break;
                        }
                        array[row, col] = count;
                        row--;
                        count++;
                    }
                    col++;
                }
                while (count <= n * n);
                for (int rows = 0; rows < array.GetLength(0); rows++)
                {
                    for (int cols = 0; cols < array.GetLength(1); cols++)
                    {
                        Console.Write("{0,3}", array[rows, cols]);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Incorrect input!");
            }
        }
    }
}