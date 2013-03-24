using System;

class CalculateAge
{
    static void Main()
    {
        Console.WriteLine("Please enter your age:");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("After 10 years you will be at {0} years!", age + 10);
    }
}
