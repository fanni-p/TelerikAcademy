using System;

namespace _2.Person
{
    class Person
    {
        private string name;
        private int? age;

        public int? Age { get { return this.age; } set { this.age = value; } }
        public string Name { get { return name; } set { name = value; } }

        public Person(string name, int? age)
        {
            this.Name = name;
            this.Age = age;
        }
        public Person(string name)
            : this(name, null)
        {
        }

        public override string ToString()
        {
            return string.Format("Person name: {0}, age: {1}", this.Name, this.Age != null ? this.Age.ToString() : "Undefined");
        }
    }
}
