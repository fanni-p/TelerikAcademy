using System;

namespace _2.Bank
{
    class DepositeAccount : Account
    {
        public DepositeAccount(Client customer, double monthInterestRate, double balance = 0)
            : base(customer, monthInterestRate, balance)
        {
        }

        public void WithdrawMoney(double money)
        {
            if (this.Balance < money)
            {
                throw new ArgumentException("Not enough money.");
            }
            else
            {
                Balance -= money;
            }
        }

        public override double CalculateInterestAmount(int numberOfMonths)
        {
            if (this.Balance >= 1000)
            {
                return numberOfMonths * MonthInterestRate;
            }
            return 0;
        }
    }
}
