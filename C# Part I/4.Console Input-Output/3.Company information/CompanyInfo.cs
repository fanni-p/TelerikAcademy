using System;

namespace _3.Company_information
{
    class CompanyInfo
    {
        static void Main()
        {
            Console.Write("Enter company name:");
            string compName = Console.ReadLine();

            Console.Write("Enter company address:");
            string compAddress = Console.ReadLine();

            Console.Write("Enter company phone number:");
            int compPhone = int.Parse(Console.ReadLine());

            Console.Write("Enter company fax number:");
            int compFax = int.Parse(Console.ReadLine());

            Console.Write("Enter company web site:");
            string compWebsite = Console.ReadLine();

            Console.Write("Enter company manager first name:");
            string firstName = Console.ReadLine();

            Console.Write("Enter company manager last name:");
            string lastName = Console.ReadLine();

            Console.Write("Enter company manager age:");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter company manager phone number:");
            int managerPhone = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("  Company Info");
            Console.WriteLine("Company name: {0}", compName);
            Console.WriteLine("Company address: {0}", compAddress);
            Console.WriteLine("Company phone number: +359/{0}", compPhone);
            Console.WriteLine("Company fax number: +359/{0}", compFax);
            Console.WriteLine("Company web site: {0}", compWebsite);
            Console.WriteLine();
            Console.WriteLine("  Manager Info");
            Console.WriteLine("Manager name: {0} {1}", firstName, lastName);
            Console.WriteLine("Manager age: {0}", age);
            Console.WriteLine("Manager phone number: +359/{0}", managerPhone);
        }
    }
}
