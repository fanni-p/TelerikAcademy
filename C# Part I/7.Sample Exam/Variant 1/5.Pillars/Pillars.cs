using System;

namespace _5.Pillars
{
    class Pillars
    {
        static void Main(string[] args)
        {
            int[,] matrix =new int [8,8];
            for (int row = 0; row <= 7; row++)
            {
                int bits = int.Parse(Console.ReadLine());
                for (int col = 0; col <=7; col++)
                {
                    matrix[row, col] = (bits >> 7-col) & 1;
                }
            }
            for (int i = 0; i <=7; i++)
            {
                int leftcount = 0;
                int rightcount = 0;
                for (int row = 0; row <=7; row++)
                {
                    for (int col = 0; col <=7; col++)
                    {
                        if (col > i)
                        {
                            leftcount += matrix[row,col];
                        }
                        if (col < i)
                        {
                            rightcount += matrix[row,col];
                        }
                    }
                }
                if (leftcount == rightcount)
                {
                    Console.WriteLine(7 - i);
                    Console.WriteLine(leftcount);
                    return;
                }
            }
            Console.WriteLine("No");
        }
    }
}
