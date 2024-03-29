﻿using System;

namespace AcademyGeometry
{
    public class Triangle : Figure, IFlat, IAreaMeasurable
    {
        private Vector3D A
        {
            get { return this.vertices[0]; }
            set { this.vertices[0] = value; }
        }

        private Vector3D B
        {
            get { return this.vertices[1]; }
            set { this.vertices[1] = value; }
        }

        private Vector3D C
        {
            get { return this.vertices[2]; }
            set { this.vertices[2] = value; }
        }

        public Triangle(Vector3D a, Vector3D b, Vector3D c)
            : base(a, b, c)
        {
        }

        public Vector3D GetNormal()
        {
            Vector3D normal = Vector3D.CrossProduct(B - A, C - A);
            normal.Normalize();
            return normal;
        }

        public double GetArea()
        {
            Vector3D AB = this.B - this.A;
            Vector3D AC = this.C - this.A;

            return Math.Abs(Vector3D.CrossProduct(AB, AC).Magnitude) / 2;
        }

        public override double GetPrimaryMeasure()
        {
            return this.GetArea();
        }
    }
}
