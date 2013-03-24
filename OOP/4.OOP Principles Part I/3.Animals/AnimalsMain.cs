using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Animals
{
    class AnimalsMain
    {
        static void Main()
        {
            List<Animal> animalList = new List<Animal>(); //Add all kinds of animals
            animalList.Add(new Frog("Jaba1", 1, Animal.Sex.Female));
            animalList.Add(new Dog("Kuche1", 4, Animal.Sex.Male));
            animalList.Add(new Cat("Kotka1", 2, Animal.Sex.Male));
            animalList.Add(new Kitten("Kitten1", 3));
            animalList.Add(new Frog("Jaba2", 5, Animal.Sex.Male));
            animalList.Add(new Dog("Kuche2", 2, Animal.Sex.Female));
            animalList.Add(new Tomcat("Tomcat1", 4));
            animalList.Add(new Frog("Jaba3", 2, Animal.Sex.Female));
            animalList.Add(new Dog("Kuche3", 4, Animal.Sex.Male));
            animalList.Add(new Cat("Kotka2", 2, Animal.Sex.Female));
            animalList.Add(new Cat("Kotka3", 5, Animal.Sex.Female));
            animalList.Add(new Dog("Kuche4", 10, Animal.Sex.Female));
            animalList.Add(new Kitten("Kitten2", 7));
            animalList.Add(new Frog("Jaba4", 4, Animal.Sex.Male));
            animalList.Add(new Tomcat("Tomcat2", 4));
            animalList.Add(new Cat("Kotka4", 1, Animal.Sex.Male));
            animalList.Add(new Kitten("Kitten3", 2));
            animalList.Add(new Tomcat("Tomcat3", 3));

            var animalGroups = from animal in animalList //Calculate avarage age by types
                 group animal by animal.GetType().Name into groups
                 select new
                 {
                     groupName = groups.Key,
                     averageSum =(from anim in groups
                          select anim.Age).Average(),
                          groupList = groups.ToList()
                 };

            foreach (var group in animalGroups) //Print all animals and avarage age
            {
                Console.WriteLine(new string('-', 80));
                foreach (var item in group.groupList)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Average age of {0}s are {1:F2}", group.groupName, group.averageSum);
                Console.WriteLine();
            }

           
        }
    }
}
