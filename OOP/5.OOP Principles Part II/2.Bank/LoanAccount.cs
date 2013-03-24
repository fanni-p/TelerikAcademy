using System;

namespace _2.Bank
{
    class LoanAccount:Account
    {
        public LoanAccount(Client customer, double monthInterestRate, double balance = 0)
            : base(customer, monthInterestRate, balance)
        {
        }

        public override double CalculateInterestAmount(int numberOfMonths)
        {
            if (this.customer is Person && numberOfMonths > 3)
            {
                return (numberOfMonths - 3) * MonthInterestRate;
            }
            if (this.customer is Company && numberOfMonths > 2)
            {
                return (numberOfMonths - 2) * MonthInterestRate;
            }
            return 0;
        }
    }
}
