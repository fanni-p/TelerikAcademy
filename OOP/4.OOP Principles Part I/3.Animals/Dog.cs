using System;

namespace _3.Animals
{
    class Dog:Animal
    {
        public Dog(string name, int age, Sex dogSex) 
            : base(name, age, dogSex) 
        { 
        }

        public override string ProduceSound()
        {
           return "Bauuu";
        }

        public override string ToString()
        {
            return String.Format("My name is {0}. I'am {1} years owd. My sex is {2}. My sound is {3}", Name, Age, AnimalSex, ProduceSound());
        }
    }
}
