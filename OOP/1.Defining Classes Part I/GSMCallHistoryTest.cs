using System;
using System.Globalization;
using System.Threading;

namespace Mobile_Device
{
    class GSMCallHistoryTest // Task 12
    {
        public static void CallHistoryTest()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            GSMClass MyGSM = new GSMClass("Galaxy", "Samsung", 990, "Petar Petrov", new BatteryClass("TI8287", 750, 21, BatteryType.LiIon), new DisplayClass(4.8, 16000000));

            MyGSM.AddCall(new Call(DateTime.Now, "0898567646",25));
            MyGSM.AddCall(new Call(DateTime.Now.AddDays(3), "087743215", 120));
            MyGSM.AddCall(new Call(DateTime.Now.AddHours(1), "0887564564", 75));
            MyGSM.AddCall(new Call(DateTime.Now.AddHours(56), "0882345678", 200));

            decimal maxDuration = MyGSM.CallHistory[0].DurationInSeconds;
            int positionMaxDurationCall = 0;

            Console.WriteLine("\n\nPrint call history: ");
            for (int i = 0; i < MyGSM.CallHistory.Count; i++)
            {
                Console.WriteLine("{0} call {1}", i + 1, MyGSM.CallHistory[i]);
                Console.WriteLine();
                if (MyGSM.CallHistory[i].DurationInSeconds > maxDuration)
                {
                    maxDuration = MyGSM.CallHistory[i].DurationInSeconds;
                    positionMaxDurationCall = i;
                }
            }
            Console.WriteLine("Total Call Price: ");
            Console.Write("The total price of your {0} calls is:  ", MyGSM.CallHistory.Count);

            Console.WriteLine(MyGSM.CalculateAllCallsPrice(MyGSM.CallHistory, 0.37m));

            MyGSM.RemoveCall(MyGSM.CallHistory[positionMaxDurationCall]);

            Console.Write("The total price of your {0} calls without the longest one is:  ", MyGSM.CallHistory.Count);
            Console.WriteLine(MyGSM.CalculateAllCallsPrice(MyGSM.CallHistory, 0.37m));

            MyGSM.ClearHistory(MyGSM.CallHistory);
            Console.Write("After clearing the history, there are {0} calls.", MyGSM.CallHistory.Count);

            Console.WriteLine();
        }
    }
}
