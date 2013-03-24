using System;
using System.Linq;

namespace _3.Array_Students
{
    class MainArrayStudents
    {
        static void Main()
        {
            Students[] array = { 
                                new Students("Angel", "Petkov"),
                                new Students("Petar","Petrov"),
                                new Students("Ivan","Angelov"),
                                new Students("Georgi", "Stoqnov")
                            };

            var studentsQuery = from student in array
                                where student.FirstName.CompareTo(student.LastName) == -1
                                select student;

            Console.WriteLine("All students whose first name is before its last name alphabetically:");
            foreach (var student in studentsQuery)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
        }
    }
}
