using System;

namespace _9_10.Nth_Catalan_number
{
    class NthCatalanNumber
    {
        static void Main()
        {
            Console.Write("Enter N = ");
            int n = int.Parse(Console.ReadLine());
            int n2 = 2*n;
            int n3 = n + 1;
            decimal factorialn = 1;
            decimal factorialn2 = 1;
            decimal factorialn3 = 1;
             if (n >= 0)
            {
                while (n >=1)
                {
                    factorialn = factorialn * n;
                    n--;
                }
                while (n2 >= 1)
                {
                    factorialn2 = factorialn2 * n2;
                    n2--;
                }
                while (n3 >= 1)
                {
                    factorialn3 = factorialn3 * n3;
                    n3--;
                }
                 Console.WriteLine("Result = {0}",factorialn2/(factorialn3*factorialn));
             }
             else
             {
                 Console.WriteLine("Incorrect input!");
             }
        }
    }
}
