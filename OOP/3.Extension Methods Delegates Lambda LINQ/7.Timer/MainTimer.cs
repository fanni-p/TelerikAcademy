using System;

namespace _7.Timer
{
    class MainTimer
    {
        public static void Print()
        {
            Console.WriteLine("This text will repeat in a few seconds!");
        }

        static void Main()
        {
            TimerClass.Repeat(Print,1,5);
        }
    }
}
