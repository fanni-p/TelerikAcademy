using System;

namespace _3.Rectangle_s_area
{
    class RectanglesArea
    {
        static void Main()
        {
            double width;
            double height;
            double area;
            Console.Write("Enter the width of the rectangle:");
            width = double.Parse(Console.ReadLine());
            Console.Write("Enter the height of the rectangle:");
            height = double.Parse(Console.ReadLine());
            if (width > 0 && height > 0)
            {
                area = width * height;
                Console.WriteLine("The area of the rectangle is {0}cm^2", area);
            }
            else
            {
                Console.WriteLine("Please enter a positive numbers!");
            }
        }
    }
}
