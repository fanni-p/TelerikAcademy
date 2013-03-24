using System;

namespace AcademyGeometry
{
    public class Cylinder:Figure,IVolumeMeasurable,IAreaMeasurable
    {
        public double Radius { get; private set; }

        public Cylinder(Vector3D top, Vector3D bottom, double radius)
            : base(top, bottom)
        {
            this.Radius = radius;
        }

        public override double GetPrimaryMeasure()
        {
            return this.GetVolume();
        }

        public double GetVolume()
        {
            return Math.PI*this.Radius*this.Radius*this.GetHeight();
        }

        public double GetArea()
        {
            double baseArea = Math.PI * this.Radius * this.Radius;
            double topAndBottomArea = baseArea * 2;

            double height = GetHeight();
            double basePerimeter = 2 * Math.PI * this.Radius;

            double sideArea = basePerimeter * height;
            return topAndBottomArea + sideArea;
        }
  
        private double GetHeight()
        {
            double height = (this.vertices[0] - this.vertices[1]).Magnitude;
            return height;
        }
    }
}
