using System;

namespace _2.Bank
{
    class Account : ICalculatable
    {
        private double balance;
        private double monthInterestRate;
        public Client customer { get; protected set; }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public double MonthInterestRate
        {
            get { return monthInterestRate; }
            set { monthInterestRate = value; }
        }


        public Account(Client customer, double monthInterestRate, double balance = 0)
        {
            this.customer = customer;
            this.MonthInterestRate = monthInterestRate;
            this.Balance = balance;
        }

        public virtual void DepositeMoney(double money)
        {
            Balance += money;
        }

        public virtual double CalculateInterestAmount(int numberOfMonths)
        {
            return numberOfMonths * MonthInterestRate;
        }
    }
}
