using System;

namespace _2.Bank
{
    class Person:Client
    {
        private long personID;
        public long PersonID
        {
            get { return personID; }
            set { personID = value; }
        }

        public Person(string name, string address, long personID)
            : base(name, address)
        {
            this.PersonID = personID;
        }
    }
}
