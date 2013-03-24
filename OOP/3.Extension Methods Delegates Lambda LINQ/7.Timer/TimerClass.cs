using System;
using System.Threading;


namespace _7.Timer
{
    public delegate void TimerDelegate(); 

    class TimerClass
    {
        public static void Repeat(TimerDelegate method, int seconds, long durationInSeconds)
        {
            int start = 0;
            while (start <= durationInSeconds) 
            {
                method();
                Thread.Sleep(seconds * 1000);
                start += seconds;
            } 
        }
    }
}
