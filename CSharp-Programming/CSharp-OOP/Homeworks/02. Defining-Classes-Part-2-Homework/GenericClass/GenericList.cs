namespace GenericClass
{
    using System;

    public class GenericList<T> where T : IComparable<T>
    {
        private const int InitialCapacity = 5; // fixed capacity
        private int count;
        private int capacity;

        private T[] elements; // list of elements of some parametric type T

        public GenericList()
        {
            this.Capacity = InitialCapacity; // fixed capacity is given as parameter in the class constructor.
            this.elements = new T[InitialCapacity];
        }

        public int Count { get; set; }

        public int Capacity { get; set; }

        // Methods

        // Task 5
        public void Add(T element) // Adding elements in the array
        {
            if (this.Count == this.Capacity)
            {
                this.AutoGrow();
            }

            this.elements[this.Count] = element;
            this.Count++;
        }

        // Task 5
        public void RemoveAtIndex(int index)
        {
            if (index >= this.Count || index < 0)
            {
                throw new IndexOutOfRangeException(String.Format("Invalid index: {0}", index));
            }

            for (int i = index; i < this.Count - 1; i++) // the elements that we want to remove is equal to the next element int the array etc..
            {
                this.elements[i] = this.elements[i + 1];
            }
            this.Count--; // finally we decrease the Count with 1
        }

        // Task 5
        public void AddAtIndex(int index, T newElement)
        {
            if (index >= this.Capacity || index < 0)
            {
                throw new IndexOutOfRangeException(String.Format(
                "Invalid index: {0}.", index));
            }

            var temp = new GenericList<T>();

            for (int i = index; i < this.Count; i++)
            {
                temp.Add(this.elements[i]);
            }

            this.elements[index] = newElement;

            for (int i = 0, j = index + 1; i <= temp.Count; i++, j++)
            {
                this.elements[j] = temp.elements[i];
            }

            this.Count++;
        }

        // Task 5
        public void Clear()
        {
            this.elements = new T[InitialCapacity];
            this.Capacity = InitialCapacity;
            this.Count = 0;
        }

        // Task 5 
        public override string ToString()
        {
            string result = string.Empty;

            for (int i = 0; i < this.Count; i++)
            {
                result += this.elements[i];

                if (i < this.Count - 1)
                {
                    result += ", "; // to escape last comma
                }
            }
            return result;
        }

        // Task 6
        public void AutoGrow() //when the internal array is full, create a new array of double size and move all elements to it.
        {
            var oldElements = this.elements;

            this.Capacity *= 2;
            this.elements = new T[Capacity];
            Array.Copy(oldElements, this.elements, this.Count);
        }

        // Task 7
        public T Min()
        {
            if ((this.Count) < 0)
            {
                throw new ArgumentException("The list is empty, no elements found.");
            }

            T min = this.elements[0]; // we are taking as minimal val the first element

            foreach (T item in this.elements)
            {
                if (min.CompareTo(item) > 0)
                {
                    min = item;
                }
            }
            return min;
        }

        // Task 7
        public T Max()
        {
            if ((this.Count) < 0)
            {
                throw new ArgumentException("The list is empty, no elements found.");
            }

            T max = this.elements[0]; // we are taking as maximal val the first element

            foreach (T item in this.elements)
            {
                if (max.CompareTo(item) < 0)
                {
                    max = item;
                }
            }
            return max;
        }
    }
}
