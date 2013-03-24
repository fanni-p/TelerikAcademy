using System;
using System.Collections.Generic;
using System.IO;


namespace _1.Point3D
{
    public static class PathStorage // Task 4
    {
        public static Path Load(string source)
        {
            Path loadedPath = new Path();
            loadedPath.PathList = new List<Point3D>();
            char[] splittingChars = { '[', ']', ',', ';','(', ')' };
            using (StreamReader sourceFile = new StreamReader(source))
            {
                string line = sourceFile.ReadLine();

                while (line != null)
                {
                    Point3D point = new Point3D();
                    string[] splittedString = line.Split(splittingChars, StringSplitOptions.RemoveEmptyEntries);
                    point.X = int.Parse(splittedString[0]);
                    point.Y = int.Parse(splittedString[1]);
                    point.Z = int.Parse(splittedString[2]);
                    loadedPath.PathList.Add(point);
                    line = sourceFile.ReadLine();
                }
            }
            return loadedPath;
        }

        public static void Write(Path currentPath, string destinaton)
        {
            using (StreamWriter destinatonFile = new StreamWriter(destinaton))
            {
                foreach (Point3D item in currentPath.PathList)
                {
                    destinatonFile.WriteLine(item.ToString());
                }
            }
        }
    }
}
