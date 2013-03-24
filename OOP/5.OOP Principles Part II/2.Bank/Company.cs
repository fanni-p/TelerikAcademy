using System;

namespace _2.Bank
{
    class Company: Client
    {
        private int companyID;
        public int CompanyID
        {
            get { return companyID; }
            set { companyID = value; }
        }

        public Company(string name, string address, int companyID)
            : base(name, address)
        {
            this.CompanyID = companyID;
        }
    }
}
