using System;
using System.Collections.Generic;

namespace _1.Point3D
{
    class Program
    {
        static void Main()
        {
            Point3D myPoint = new Point3D(6, 1, 3); // Creating points
            Point3D point = new Point3D(3, 4, 5);
            Point3D pointZero = Point3D.Zero;

            Console.WriteLine(pointZero.ToString()); // Testing ToString
            Console.WriteLine(new string('-',40));
            Console.WriteLine(point.ToString());
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Distance calculate: {0:F2}",Distance.CalculateDistance(point, pointZero)); // Distance calculation
            Console.WriteLine(new string('-', 40));

            Path myPath = new Path();
            myPath.PathList = new List<Point3D>();
            myPath.PathList.Add(myPoint);
            myPath.PathList.Add(Point3D.Zero);

            Console.WriteLine("The Path Points after adding:"); // Add and remove points
            foreach (Point3D item in myPath.PathList)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine(new string('-', 40));
            
            myPath.PathList.Remove(Point3D.Zero);
            Console.WriteLine("The Path Points after removing the ZeroPoint:");
            foreach (Point3D item in myPath.PathList)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine(new string('-', 40));
            

            Path loadedPath = PathStorage.Load("../../Input.txt"); //Reading and writing to file
            PathStorage.Write(loadedPath, "../../Output.txt"); 

        }
    }
}
