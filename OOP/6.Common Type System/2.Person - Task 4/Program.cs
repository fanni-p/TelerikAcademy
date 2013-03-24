using System;

namespace _2.Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person petar = new Person("Petar Petrov");
            Person ivan = new Person("Ivan Ivanov", 25);
            Person atanas = new Person("Atanas Petrov", 22);
            Person gergi = new Person("Georgi Georgiev");

            Console.WriteLine("Testing class Person:");
            Console.WriteLine(petar);
            Console.WriteLine(ivan);
            Console.WriteLine(atanas);
            Console.WriteLine(gergi);
        }
    }
}
