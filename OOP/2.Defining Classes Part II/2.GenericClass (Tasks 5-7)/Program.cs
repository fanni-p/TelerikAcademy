using System;
using System.Collections.Generic;


namespace _2.GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a list of type int 
            GenericList<int> intList = new GenericList<int>(1);
            intList.Add(3);
            intList.Add(5);
            intList.InsertElement(2, 9);
            intList.Access(2);
            intList.RemoveElement(3);
            Console.WriteLine("Number of elements: {0}", intList.Count);
            Console.WriteLine(intList.ToString());
            Console.WriteLine("List<int> min value: {0}", intList.Min());
            Console.WriteLine("List<int> max value: {0}", intList.Max());

            Console.WriteLine();

            // Declare a list of type string
            GenericList<string> stringList = new GenericList<string>(2);

            stringList.Add("Fifi");
            stringList.Add("Pipi");
            stringList.Add("Kuku");
            stringList.InsertElement(3,"Lolo");
            stringList.RemoveElement(4);
            Console.WriteLine("Number of elements: {0}", stringList.Count);
            Console.WriteLine(stringList.ToString());
            Console.WriteLine("Find Element \"Lolo\" index: {0}",stringList.FindElement("Lolo"));
            Console.WriteLine("List<string> min value: {0}", stringList.Min());
            Console.WriteLine("List<string> max value: {0}", stringList.Max());
            Console.WriteLine();
            stringList.ClearElements();
            Console.WriteLine("Clear list: {0}",stringList.ToString());
        }
    }
}
