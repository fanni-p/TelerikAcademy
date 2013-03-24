using System;

namespace _3.Animals
{
    class Cat:Animal
    {
        public Cat(string name, int age, Sex catSex) 
            : base(name, age, catSex) 
        { 
        }

        public override string ProduceSound()
        {
           return "Miauuu";
        }

        public override string ToString()
        {
            return String.Format("My name is {0}. I'am {1} years owd. My sex is {2}. My sound is {3}", Name, Age, AnimalSex, ProduceSound());
        }
    }
}
