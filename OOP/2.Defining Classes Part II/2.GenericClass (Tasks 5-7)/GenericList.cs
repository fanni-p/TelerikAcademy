using System;
using System.Collections.Generic;
using System.Text;


namespace _2.GenericClass
{
    class GenericList<T> where T : IComparable<T> // Task 5
    {
        private T[] elements;
        public int count;

        public int Count
        {
            get { return this.count; }
        }

        public T this[int index]
        {
            get
            {
                if (index >= count)
                {
                    throw new IndexOutOfRangeException();
                }
                T result = elements[index];
                return result;
            }
        }

        public GenericList(int count)
        {
            elements = new T[count];
        }

        public void Add(T element)
        {
            if (count >= elements.Length)
            {
                DoubleCapacity();
            }
            this.elements[count] = element;
            count++;
        }

        public T Access(int index)
        {
            if (index >= count)
            {
                throw new IndexOutOfRangeException();
            }
            T result = elements[index];
            return result;
        }

        public int FindElement(T element)
        {
            int index = Array.IndexOf(elements, element);
            return index;
        }

        public void InsertElement(int index, T element)
        {
            count++;
            if (count >= elements.Length)
            {
                DoubleCapacity();
            }
            for (int i = count; i > index; i--)
            {
                elements[i] = elements[i - 1];
            }
            elements[index] = element;
        }

        public void RemoveElement(int index)
        {
            if (index < 0 || index > count)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                for (int i = index + 1; i < this.count; i++)
                {
                    elements[i - 1] = elements[i];
                }
                count--;
            }
        }

        public void ClearElements()
        {
            elements = new T[elements.Length];
            count = 0;
        }

        private void DoubleCapacity() // Task 6
        {
            T[] tempArray = new T[elements.Length * 2];
            Array.Copy(elements, 0, tempArray, 0, elements.Length);
            elements = tempArray;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i <= count; i++)
            {
                result.Append("Element ["+ i + "] --> ");
                result.Append(elements[i] + "\n");
            }
            return result.ToString();
        }

        public T Min() // Task 7
        {
            if (count == -1)
            {
                throw new InvalidOperationException();
            }
            T min = elements[0];
            for (int i = 1; i <= count; i++)
            {
                if (min.CompareTo(elements[i]) > 0)
                {
                    min = elements[i];
                }
            }
            return min;
        }

        public T Max()
        {
            if (count == -1)
            {
                throw new InvalidOperationException();
            }
            T max = elements[0];
            for (int i = 1; i <= count; i++)
            {
                if (max.CompareTo(elements[i]) < 0)
                {
                    max = elements[i];
                }
            }
            return max;
        }
    }
}
