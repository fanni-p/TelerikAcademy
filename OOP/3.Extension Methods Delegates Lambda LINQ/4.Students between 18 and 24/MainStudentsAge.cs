using System;
using System.Linq;

namespace _4.Students_between_18_and_24
{
    class MainStudentsAge
    {
        static void Main()
        {
            Students[] array = { 
                                   new Students("Angel", "Ivanov", 20),
                                   new Students("Petar", "Petrov", 25),
                                   new Students("Ivan", "Georgiev",19),
                                   new Students("Georgi", "Stoianov",18)
                               };

            var studentsQuery = from student in array
                                where (student.Age>=18)&&(student.Age<25)
                                select student;

            Console.WriteLine("All students with age between 18 and 24:");
            foreach (var student in studentsQuery)
            {
                Console.WriteLine("{0} {1} --> age {2}",student.FirstName,student.LastName,student.Age);
            }
        }
    }
}
