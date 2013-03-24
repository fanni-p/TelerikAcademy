using System;

namespace _10.Firm_Database
{
    class FirmDatabase
    {
        static void Main()
        {
            string firstName = "Fani";
            string familyName = "Petkova";
            byte age = 26;
            char gender = 'f';
            long ID = 9999999999;
            uint employeeNumber = 27569999;
            Console.WriteLine("First name:{0},\nLast name:{1},\nAge:{2},\nGender:{3},\nID:{4},\nUnique Employee Number:{5}",
                firstName, familyName, age, gender, ID, employeeNumber); 
        }
    }
}
