using System;

namespace Mobile_Device
{
    public enum BatteryType // Task 3
    {
        LiIon, NiMH, NiCD
    }

    class BatteryClass
    {
        private string batteryModel;
        private double? hoursIdle;
        private double? hoursTalk;
        private BatteryType type;

        public string Model
        {
            get { return this.batteryModel; }
            set
            {
                if (value.Length>0)
                {
                    this.batteryModel = value;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }

        public double? HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value>0)
                {
                    this.hoursIdle = value;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }

        public double? HoursTalk
        {   
            get{return this.hoursTalk;}
            set
            {
                if (value>0)
                {
                    this.hoursTalk = value;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }

        public BatteryType Type 
        {
            get { return this.type; }
        }

        public BatteryClass(string batteryModel, BatteryType type)
        {
            this.Model = batteryModel;
            this.type = type;
        }
        public BatteryClass(string batteryModel, double? hoursIdle, double? hoursTalk, BatteryType type)
            : this(batteryModel, type)
        {
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }
    }
}
