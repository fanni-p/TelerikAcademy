using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile_Device
{
    class GSMClass //Task 1
    {
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;

        private static GSMClass iPhone4S; //Task 6

        public DisplayClass Display{get;set;}
        public BatteryClass Battery{get;set;}
        public List<Call> CallHistory {get; set; } // Task 9

        public static GSMClass IPhone4s //Task 6
        {
            get { return iPhone4S; }
        }

        public string GsmModel //Task 5
        {
            get { return this.model; }
            set
            {
                if (value.Length > 0)
                {
                    this.model = value;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (value.Length > 0)
                {
                    this.manufacturer = value;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }

        public decimal? Price
        {
            get { return this.price; }
            set
            {
                if (value>=0)
                {
                    this.price = value;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }

        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (value.Length > 0)
                {
                    this.owner = value;
                }
                else
                {
                    System.Console.WriteLine("Owner should contain at least one character!");
                }
            }
        }

        static GSMClass() //Task 2
        {
            iPhone4S = new GSMClass("IPhone4S", "Apple", 1000);
            iPhone4S.Owner = "Ivan Ivanov";
            iPhone4S.Display = new DisplayClass(3.5, 160000000);
            iPhone4S.Battery = new BatteryClass("616-0580", 200, 12, BatteryType.NiMH);
        }
        public GSMClass(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            price = null;
            owner = null;
        }
        public GSMClass(string model, string manufacturer, decimal? price)
            : this(model, manufacturer)
        {
            this.price = price;
        }
        public GSMClass(string model, string manufacturer, decimal? price, string owner, BatteryClass battery, DisplayClass display)
            : this(model, manufacturer, price)
        {
            this.owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        public override string ToString() // Task 4
        {
            StringBuilder gsmInfo = new StringBuilder();
            gsmInfo.Append("Information of GSM device:");
            gsmInfo.Append("\nModel: " + this.GsmModel);
            gsmInfo.Append("\nManufacturer: " + this.Manufacturer);
            if (this.Price != null) 
            {
                gsmInfo.Append("\nPrice: " + this.Price);
            }
            if (this.Owner != null)
            {
                gsmInfo.Append("\nOwner: " + this.Owner);
            }
            if (this.Battery.Model != null)
            {
                gsmInfo.Append("\nBattery Model: " + this.Battery.Model);
            }
            if (this.Battery.HoursIdle != null)
            {
                gsmInfo.Append("\nBattery Hours Idle Time: " + this.Battery.HoursIdle);
            }
            if (this.Battery.HoursTalk != null)
            {
                gsmInfo.Append("\nBattery Hours Talk Time: " + this.Battery.HoursTalk);
            }
            if (this.Battery.Type != null)
            {
                gsmInfo.Append("\nBattery Type: " + this.Battery.Type);
            }
            if (this.Display.DisplaySize != null)
            {
                gsmInfo.Append("\nDisplay Size: " + this.Display.DisplaySize);
            }
            if (this.Display.DisplayColors != null)
            {
                gsmInfo.Append("\nDisplay Colors: " + this.Display.DisplayColors);
            }
            return gsmInfo.ToString();
        }

        public void AddCall(Call call) //Task 10
        {
            if (CallHistory == null)
            {
                CallHistory = new List<Call>();
            }
            this.CallHistory.Add(call);
        }
        public void RemoveCall(Call call)
        {
            this.CallHistory.Remove(call);
        }
        public void ClearHistory(List<Call> CallHistory)
        {
            CallHistory.Clear();
        }
        public decimal CalculateAllCallsPrice(List<Call> CallHistory, decimal pricePerMinute) //Task 11
        {
            decimal price = 0;
            for (int i = 0; i < CallHistory.Count; i++)
            {
                price = price + this.CallHistory[i].DurationInSeconds * (pricePerMinute / 60);
            }
            return Math.Round(price, 2);
        }

    }
}