using System;

namespace Mobile_Device
{
    class Call //Task 8
    {
        public DateTime DateAndTime { get; set; }

        private string dialedPhone;
        private decimal durationInSeconds;

        public string DialedPhone
        {
            get { return this.dialedPhone; }
            set
            {
                if (value.Length >= 3)
                {
                    this.dialedPhone = value;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }

        public decimal DurationInSeconds
        {
            get { return this.durationInSeconds; }
            set
            {
                if (value > 0)
                {
                    this.durationInSeconds = value;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }

        public Call(DateTime dateAndTime, string dialedPhone, decimal durationInSeconds)
        {
            this.DateAndTime = dateAndTime;
            this.DialedPhone = dialedPhone;
            this.DurationInSeconds = durationInSeconds;
        }

        public override string ToString()
        {
            string result = String.Format("Date and Time: " + this.DateAndTime + "\nDialed phone " + this.DialedPhone +
                "\nDuration in seconds: " + this.DurationInSeconds);
            return result;
        }
    }
}
