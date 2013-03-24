using System;
using System.Collections.Generic;

namespace _2.Bank
{
    class BankTestMain
    {
        static void Main()
        {
            List<Client> customers = new List<Client>();
            customers.Add(new Person("Georgi Georgiev", "Sofia", 0000001));
            customers.Add(new Company("Company 1", "Plovdiv", 12345678));
            customers.Add(new Person("Ivan Ivanov", "Varna", 0000002));
            customers.Add(new Person("Stanslav Stefanoc", "Sofia", 0000003));
            customers.Add(new Company("Company 2", "Burgas", 12345677));
            customers.Add(new Company("Company 3", "Sofia", 12345679));

            List<Account> accounts = new List<Account>();
            accounts.Add(new DepositeAccount(customers[0], 0.568, 1500));
            accounts.Add(new DepositeAccount(customers[1], 0.871, 9300));
            accounts.Add(new LoanAccount(customers[2], 0.698, 15000));
            accounts.Add(new LoanAccount(customers[3], 0.366, 6500));
            accounts.Add(new MortgageAccount(customers[4], 0.683, 10500));
            accounts.Add(new MortgageAccount(customers[5], 0.482, 3500));
            
            Random rand = new Random();

            foreach (var item in accounts)
            {
                int months = rand.Next(1, 16);
                Console.WriteLine("{0} has {1:F2}, with MIRate {2} has {3:F2} for {4} months", item.customer.Name, item.Balance, item.MonthInterestRate, item.CalculateInterestAmount(months), months);
                Console.WriteLine();
            }
        }
    }
}
