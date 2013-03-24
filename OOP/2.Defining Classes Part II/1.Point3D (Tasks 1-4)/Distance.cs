using System;

namespace _1.Point3D
{
    public static class Distance
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint) // Task 3
        {
            double calc = Math.Sqrt(Math.Pow(firstPoint.X - secondPoint.X, 2) + Math.Pow(firstPoint.Y - secondPoint.Y, 2) + Math.Pow(firstPoint.Z - secondPoint.Z, 2));
            return calc;
        }
    }
}
