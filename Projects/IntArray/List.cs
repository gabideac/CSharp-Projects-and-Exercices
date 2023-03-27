using System;
using System.Collections;
using System.Collections.Generic;

namespace IntArray
{
    public class List<T> : IList<T>
    {
        private T[] list;

        public List() => list = new T[4];

        public int Count { get; protected set; }

        public bool IsReadOnly
        {
            get => false;
        }

        public T this[int index]
        {
            get
            {
                CheckForArgumentOutOfRangeException(index, "Index is out of range");
                return list[index];
            }

            set
            {
                CheckForArgumentOutOfRangeException(index, "Index is out of range");
                list[index] = value;
            }
        }

        public bool Contains(T item) => IndexOf(item) != -1;

        public void Add(T item)
        {
            CapacityCheck();
            list[Count] = item;
            Count++;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (list[i].Equals(item))
                {
                        return i;
                }
            }

            return -1;
        }

        public void Insert(int index, T item)
        {
            CheckForArgumentOutOfRangeException(index, "Index is out of range");
            CapacityCheck();
            ShiftRight(index);
            list[index] = item;
            Count++;
        }

        public void Clear()
        {
            Count = 0;
        }

        public bool Remove(T item)
        {
            int indexOfElement = IndexOf(item);
            if (indexOfElement != -1)
            {
                RemoveAt(indexOfElement);
            }

            return indexOfElement > -1;
        }

        public void RemoveAt(int index)
        {
            CheckForArgumentOutOfRangeException(index, "Index is out of range");

            ShiftLeft(index);
            Count--;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            CheckForArgumentNullException(array);
            CheckForArgumentException(array.Length - arrayIndex, "The number of elements in the source list is greater than the available space from arrayIndex to the end of the destination array.");
            CheckForArgumentOutOfRangeException(arrayIndex, "Index is less than 0.");

            for (int i = 0; i < Count; i++)
            {
                array[i + arrayIndex] = list[i];
            }
        }

        public void ShiftRight(int index)
        {
            for (int i = Count; i > index; i--)
            {
                list[i] = list[i - 1];
            }
        }

        public void ShiftLeft(int index)
        {
            for (int i = index; i < Count - 1; i++)
            {
                list[i] = list[i + 1];
            }
        }

        public void CapacityCheck()
        {
            if (list.Length == Count)
            {
                Array.Resize(ref list, list.Length * 2);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        private static void CheckForArgumentNullException(T[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }
        }

        private void CheckForArgumentOutOfRangeException(int index, string errorMessage)
        {
            if (index >= Count || index < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(index), errorMessage);
            }
        }

        private void CheckForArgumentException(int remainingCapacity, string errorMessage)
        {
            if (Count > remainingCapacity)
            {
                throw new ArgumentException(errorMessage);
            }
        }
    }
}