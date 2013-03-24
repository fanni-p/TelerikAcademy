using System;

namespace _3.Animals
{
    class Tomcat:Cat
    {
        public const Sex TomcatSex = Sex.Male;

        public Tomcat(string name, int age)
            : base(name, age, TomcatSex)
        {
        }

        public override string ToString()
        {
            return String.Format("My name is {0}. I'am {1} years owd. My sex is {2}. My sound is {3}", Name, Age, AnimalSex, ProduceSound());
        }
    }
}
