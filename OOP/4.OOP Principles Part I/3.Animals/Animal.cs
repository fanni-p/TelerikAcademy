using System;

namespace _3.Animals
{
    public abstract class Animal:ISound
    {
        public enum Sex { Male, Female }
        private string name;
        private int age;

        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public Sex AnimalSex { get; set; }

        public Animal(string name, int age, Sex sex)
        {
            this.Name = name;
            this.Age = age;
            this.AnimalSex = sex;
        }

        public abstract string ProduceSound();
    }
}
