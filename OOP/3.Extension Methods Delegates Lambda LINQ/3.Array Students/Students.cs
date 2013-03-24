using System;

namespace _3.Array_Students
{
    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Students(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
