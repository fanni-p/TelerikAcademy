using System;

namespace _2.Human
{
    class Worker:Human
    {
        public decimal moneyPerHour;
        private decimal weekSalary;
        private decimal workHoursPerDay;

        public decimal WeekSalary { get { return weekSalary; } set { weekSalary = value; } }
        public decimal WorkHoursPerDay { get { return workHoursPerDay; } set { workHoursPerDay = value; } }

        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal MoneyPerHour()
        {
            moneyPerHour = (WeekSalary/5)/WorkHoursPerDay;
            return moneyPerHour;
        }
    }
}
