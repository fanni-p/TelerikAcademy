using System;

namespace _5.Students_OrderBy
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
