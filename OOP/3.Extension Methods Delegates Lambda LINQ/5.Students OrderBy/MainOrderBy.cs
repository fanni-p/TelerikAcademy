using System;
using System.Linq;

namespace _5.Students_OrderBy
{
    class MainOrderBy
    {
        static void Main()
        {

            Students[] array = { 
                                new Students("Angel", "Petkov"),
                                new Students("Angel", "Angelov"),
                                new Students("Petar","Petrov"),
                                new Students("Georgi","Angelov"),
                                new Students("Georgi", "Stoqnov")
                            };

            var studentsLinq = from student in array // LINQ Query
                                orderby student.FirstName descending, student.LastName descending
                                select student;

            var studentsLambda = array.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName); //Lambda expression
           

            Console.WriteLine("Students sorted with LINQ by first name and last name in descending order:"); // LINQ Query
            foreach (var student in studentsLinq)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine();

            Console.WriteLine("Students sorted with lambda expressions in descending order:"); //Lambda expression
            foreach (var student in studentsLambda)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine();
        }
    }
}
