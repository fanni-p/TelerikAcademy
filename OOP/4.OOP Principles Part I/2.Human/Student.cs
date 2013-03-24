using System;

namespace _2.Human
{
    class Student:Human
    {
        private double grade;

        public double Grade { get { return grade; } set { grade = value; } }

        public Student(string firstName, string lastName, double grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }
    }
}
