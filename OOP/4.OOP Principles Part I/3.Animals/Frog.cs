using System;

namespace _3.Animals
{
    class Frog:Animal
    {
        public Frog(string name, int age, Sex frogSex) 
            : base(name, age, frogSex) 
        { 
        }

        public override string ProduceSound()
        {
           return "Quackkk";
        }

        public override string ToString()
        {
            return String.Format("My name is {0}. I'am {1} years owd. My sex is {2}. My sound is {3}", Name, Age, AnimalSex, ProduceSound());
        }
    }
}
