using System;

namespace _1.Point3D
{
    public struct Point3D // Task 1
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        static public readonly Point3D Zero = new Point3D(0, 0, 0); // Task 2

        public Point3D(int x, int y, int z):this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString() // Task 1
        {
            string printPoint = string.Format("Point X: {0}, Point Y: {1}, Point Z: {2}", X.ToString(), Y.ToString(), Z.ToString());
            return printPoint;
        }

    }
}
