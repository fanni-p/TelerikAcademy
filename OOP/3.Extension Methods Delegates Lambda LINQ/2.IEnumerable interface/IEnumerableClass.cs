using System;
using System.Collections.Generic;

namespace _2.IEnumerable_interface
{
    public static class IEnumerableClass 
    {
        public static T Sum<T>(this IEnumerable<T> elements)
        {
            dynamic sum = 0;
            foreach (var element in elements)
            {
                sum += (dynamic)element;
            }
            return sum;
        }

        public static T Product<T>(this IEnumerable<T> elements)
        {
            dynamic product = 1;
            foreach (var element in elements)
            {
                product *= element;
            }
            return product;
        }

        public static T Min<T>(this IEnumerable<T> elements) where T : IComparable<T>
        {
            dynamic min = int.MaxValue;
            foreach (var element in elements)
            {
                if (element < min)
                {
                    min = element;
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> elements) where T : IComparable<T>
        {
            dynamic max = int.MinValue;
            foreach (var element in elements)
            {
                if (element > max)
                {
                    max = element;
                }
            }
            return max;
        }

        public static decimal Average<T>(this IEnumerable<T> elements) where T : IComparable<T>
        {
            dynamic sum = 0;
            decimal counter = 0;
            foreach (var element in elements)
            {
                sum += element;
                counter++;
            }
            return sum / counter;
        }
    }
}
