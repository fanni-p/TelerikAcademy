using System;

namespace _9.Subset_sum_0
{
    class SubsetSum0
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1 number: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter 2 number: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Enter 3 number: ");
            int n3 = int.Parse(Console.ReadLine());
            Console.Write("Enter 4 number: ");
            int n4 = int.Parse(Console.ReadLine());
            Console.Write("Enter 5 number: ");
            int n5 = int.Parse(Console.ReadLine());
            byte count = 0;

            if (n1 + n2 + n3 + n4 + n5 == 0)
            {
                count++;
                Console.WriteLine("The sum of {0} + {1} + {2} + {3} + {4} = 0", n1, n2, n3, n4, n5);
            }
            if (n1 + n2 + n3 + n4 == 0)
            {
                count++;
                Console.WriteLine("The sum of {0} + {1} + {2} + {3} = 0", n1, n2, n3, n4);
            }
            if (n1 + n2 + n3 + n5 == 0)
            {
                count++;
                Console.WriteLine("The sum of {0} + {1} + {2} + {3} = 0", n1, n2, n3, n5);
            }
            if (n1 + n2 + n4 + n5 == 0)
            {
                count++;
                Console.WriteLine("The sum of {0} + {1} + {2} + {3} = 0", n1, n2, n4, n5);
            }
            if (n1 + n3 + n4 + n5 == 0)
            {
                count++;
                Console.WriteLine("The sum of {0} + {1} + {2} + {3} = 0", n1, n3, n4, n5);
            }
            if (n2 + n3 + n4 + n5 == 0)
            {
                count++;
                Console.WriteLine("The sum of {0} + {1} + {2} + {3} = 0", n2, n3, n4, n5);
            }
            if (n1 + n2 + n3 == 0)
            {
                count++;
                Console.WriteLine("The sum of {0} + {1} + {2} = 0", n1, n2, n3);
            }
            if (n1 + n2 + n4 == 0)
            {
                count++;
                Console.WriteLine("The sum of {0} + {1} + {2} = 0", n1, n2, n4);
            }
            if (n1 + n2 + n5 == 0)
            {
                count++;
                Console.WriteLine("The sum of {0} + {1} + {2} = 0", n1, n2, n5);
            }
            if (n1 + n3 + n4 == 0)
            {
                count++;
                Console.WriteLine("The sum of {0} + {1} + {2} = 0", n1, n3, n4);
            }
            if (n1 + n3 + n5 == 0)
            {
                count++;
                Console.WriteLine("The sum of {0} + {1} + {2} = 0", n1, n3, n5);
            }
            if (n1 + n4 + n5 == 0)
            {
                count++;
                Console.WriteLine("The sum of {0} + {1} + {2} = 0", n1, n4, n5);
            }
            if (n2 + n3 + n4 == 0)
            {
                count++;
                Console.WriteLine("The sum of {0} + {1} + {2} = 0", n2, n3, n4);
            }
            if (n2 + n3 + n5 == 0)
            {
                count++;
                Console.WriteLine("The sum of {0} + {1} + {2} = 0", n2, n3, n5);
            }
            if (n2 + n4 + n5 == 0)
            {
                count++;
                Console.WriteLine("The sum of {0} + {1} + {2} = 0", n2, n4, n5);
            }
            if (n3 + n4 + n5 == 0)
            {
                count++;
                Console.WriteLine("The sum of {0} + {1} + {2} = 0", n3, n4, n5);
            }
            if (n1 + n2 == 0)
            {
                count++;
                Console.WriteLine("The sum of {0} + {1} = 0", n1, n2);
            }
            if (n1 + n3 == 0)
            {
                count++;
                Console.WriteLine("The sum of {0} + {1} = 0", n1, n3);
            }
            if (n1 + n4 == 0)
            {
                count++;
                Console.WriteLine("The sum of {0} + {1} = 0", n1, n4);
            }
            if (n1 + n5 == 0)
            {
                count++;
                Console.WriteLine("The sum of {0} + {1} = 0", n1, n5);
            }
            if (n2 + n3 == 0)
            {
                count++;
                Console.WriteLine("The sum of {0} + {1} = 0", n2, n3);
            }
            if (n2 + n4 == 0)
            {
                count++;
                Console.WriteLine("The sum of {0} + {1} = 0", n2, n4);
            }
            if (n2 + n5 == 0)
            {
                count++;
                Console.WriteLine("The sum of {0} + {1} = 0", n2, n5);
            }
            if (n3 + n4 == 0)
            {
                count++;
                Console.WriteLine("The sum of {0} + {1} = 0", n3, n4);
            }
            if (n3 + n5 == 0)
            {
                count++;
                Console.WriteLine("The sum of {0} + {1} = 0", n3, n5);
            }
            if (n4 + n5 == 0)
            {
                count++;
                Console.WriteLine("The sum of {0} + {1} = 0", n4, n5);
            }
            if (count > 0)
            {
                Console.WriteLine("There are {0} subsets with sum zero.", count);
            }
            else
            {
                Console.WriteLine("There are no subsets with sum zero.");
            }
        }
    }
}
