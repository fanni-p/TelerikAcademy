using System;
using System.Collections.Generic;
using System.Linq;
namespace _2.Human
{
    class HumanMain
    {
        static void Main()
        {
            List<Student> studentsList = new List<Student>(); //Add 10 Students
            studentsList.Add(new Student("Ivan", "Petrov", 4.5));
            studentsList.Add(new Student("Petar", "Ivanov", 3.75));
            studentsList.Add(new Student("Angel", "Lozanov", 5));
            studentsList.Add(new Student("Pavel", "Marinov", 4.25));
            studentsList.Add(new Student("Atanas", "Varbanov", 6));
            studentsList.Add(new Student("Georgi", "Todorov", 5.45));
            studentsList.Add(new Student("Hristo", "Hristov", 3));
            studentsList.Add(new Student("Radoslav", "Petkov", 4.75));
            studentsList.Add(new Student("Veselin", "Veselinov", 4));
            studentsList.Add(new Student("Kiril", "Kirilov", 5.75));

            List<Worker> workersList = new List<Worker>(); //Add 10 Workers
            workersList.Add(new Worker("Ivan", "Petrov", 100,4));
            workersList.Add(new Worker("Petar", "Ivanov", 200,4));
            workersList.Add(new Worker("Angel", "Lozanov", 300,6));
            workersList.Add(new Worker("Pavel", "Marinov", 400,6));
            workersList.Add(new Worker("Atanas", "Varbanov",500,7));
            workersList.Add(new Worker("Georgi", "Todorov", 600,7));
            workersList.Add(new Worker("Hristo", "Hristov", 700,8));
            workersList.Add(new Worker("Radoslav", "Petkov", 800,8));
            workersList.Add(new Worker("Veselin", "Veselinov", 900,8));
            workersList.Add(new Worker("Kiril", "Kirilov", 1000,10));


            var sortedStudents = from student in studentsList // LINQ Query sorting Students
                               orderby student.Grade ascending
                               select student;

            var sortedWorkers = from worker in workersList // LINQ Query sorting Workers
                                orderby worker.MoneyPerHour() descending
                                select worker;

            List<Human> merge = new List<Human>(studentsList);// Merge students and workers
            merge.AddRange(workersList);

            var mergeSort = from member in merge // LINQ Query sorting Merge List
                            orderby member.FirstName, member.LastName
                            select member;


            //Printing Lists
            Console.WriteLine(new string('-', 80));
            Console.WriteLine("Students sorted by grade in ascending order:");
            Console.WriteLine(new string('-', 80));
            foreach (var student in sortedStudents)
            {
                Console.WriteLine("{0} {1} - {2:F2}",student.FirstName,student.LastName,student.Grade);
            }

            Console.WriteLine(new string('-', 80));
            Console.WriteLine("Workers sorted by money per hour in descending order:");
            Console.WriteLine(new string('-', 80));
            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine("{0} {1} - {2:F2}", worker.FirstName,worker.LastName,worker.moneyPerHour);
            }

            Console.WriteLine(new string('-', 80));
            Console.WriteLine("Merge list sorted by first name and last name:");
            Console.WriteLine(new string('-', 80));
            foreach (var member in mergeSort)
            {
                Console.WriteLine("{0} {1}", member.FirstName, member.LastName);
            }
        }
    }
}
