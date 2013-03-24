using System;

namespace _2.Bank
{
    class Client
    {
        private string name;
        private string address;

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        public string Address
        {
            get { return address; }
            private set { address = value; }
        }

        public Client(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }
    }
}
