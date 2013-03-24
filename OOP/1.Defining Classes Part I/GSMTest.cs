using System;
using System.Globalization;
using System.Threading;

namespace Mobile_Device
{
    class GSMTest // Task 7
    {
        public static void TestGSM()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            GSMClass nokia = new GSMClass("N9", "Nokia", 800, "Grigor Grigorov", new BatteryClass("BV-5JW", 380, 11, BatteryType.LiIon), new DisplayClass(3.9, 16000000));
            GSMClass htc = new GSMClass("One X +", "HTC", 850, "Iva Ivanova", new BatteryClass("BJ83100", 360, 12, BatteryType.NiCD), new DisplayClass(4.7, 16000000));
            GSMClass samsung = new GSMClass("Galaxy", "Samsung", 990, "Petar Petrov", new BatteryClass("TI8287", 750, 21, BatteryType.LiIon), new DisplayClass(4.8, 16000000));

            Console.WriteLine("GSM Test:\n ");
            GSMClass[] gsms = new GSMClass[] { nokia, htc, samsung };
            foreach (GSMClass phone in gsms)
            {
                Console.WriteLine(phone.ToString());
                Console.WriteLine();
            }
            Console.WriteLine(GSMClass.IPhone4s);
        }
    }
}
