using System;
using System.Collections.Generic;

namespace _1.Student___Task_1_2_3
{
    class StudentTestMain
    {
        static void Main(string[] args)
        {
            //Add Student and copy
            Student first = new Student("Petar", "Petrov", "Petrov", 123, "Sofia", "12345678", "p@apetrov.bg", 2, Specialties.SoftwareEngineering, Universities.TechnicalUniversity, Faculties.ComputerSystemsAndControl);
            Student cloned = first.Clone();

            //Add more students to List and sort them
            Student second = new Student("Ivan", "Ivanov", "Petrov", 456, "Plovdiv", "87654321", "ivan@a.com", 2, Specialties.Mathematics, Universities.SofiaUniversity, Faculties.MathematicsAndInformatics);
            Student third = new Student("Atanas", "Atanasov", "Atanasov", 789, "Varna", "543212987", "atanasov@b.com", 3, Specialties.FinancialControl, Universities.UNWE, Faculties.FinancesandAccountancy);
            Student fourth = new Student("Maria", "Marinova", "Marinova", 910, "Sofia", "896432426", "mimeto@v.com", 4, Specialties.BusinessAdministration, Universities.SofiaUniversity, Faculties.EconomicsAndBusinessAdministration);
            
            List<Student> sortedStudents = new List<Student>();
            sortedStudents.Add(first);
            sortedStudents.Add(second);
            sortedStudents.Add(cloned);
            sortedStudents.Add(third);
            sortedStudents.Add(fourth);

            sortedStudents.Sort();

            //Clone testing
            Console.WriteLine("Original:\n{0}", first);
            Console.WriteLine(new string('-', 80));
            Console.WriteLine("Cloned:\n{0}", cloned);
            Console.WriteLine(new string('-', 80));
            Console.WriteLine("First and Cloned are the same students: {0}", first.Equals(cloned));
            Console.WriteLine(new string('-', 80));

            //Change clone test
            //cloned.SSN = 2323;
            //Console.WriteLine("Cloned with changed SSN:");
            //Console.WriteLine(cloned);
            //Console.WriteLine(new string('-', 80));
            //Console.WriteLine("Original of the cloned:");
            //Console.WriteLine(first);
            //Console.WriteLine(new string('-', 80));
            //Console.WriteLine("First and Cloned are the same students after the change of SSN of cloned: {0}", first.Equals(cloned));
            //Console.WriteLine(new string('-', 80));

            //Testing sorted students 
            //Console.WriteLine("The sorted students are:");
            //foreach (var student in sortedStudents)
            //{
            //    Console.WriteLine(student);
            //    Console.WriteLine(new string('-', 80));
            //}
        }
    }
}
