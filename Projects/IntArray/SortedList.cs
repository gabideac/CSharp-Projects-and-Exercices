using System;
using System.Collections;
using System.Collections.Generic;

namespace IntArray
{
    class SortedList<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        private readonly List<T> sortedList;

        public SortedList()
        {
            sortedList = new List<T>();
        }

        public int Count => sortedList.Count;

        public T this[int index]
        {
            get => sortedList[index];
            set
            {
                if (Belongs(index, value, false))
                {
                    sortedList[index] = value;
                }
            }
        }

        public bool Contains(T element) => sortedList.Contains(element);

        public void Add(T element)
        {
            for (int i = 0; i < Count; i++)
            {
                if (Belongs(i, element, true))
                {
                    sortedList.Insert(i, element);
                    return;
                }
            }

            sortedList.Add(element);
        }

        public int IndexOf(T element) => sortedList.IndexOf(element);

        public void Insert(int index, T element)
        {
            if (Belongs(index, element, true))
            {
                sortedList.Insert(index, element);
            }
        }

        public void Clear() => sortedList.Clear();

        public void Remove(T element) => sortedList.Remove(element);

        public void RemoveAt(int index) => sortedList.RemoveAt(index);

        public bool Belongs(int index, T element, bool insertCase)
        {
            bool previousCompare = index == 0 || sortedList[index - 1].CompareTo(element) <= 0;
            bool nextCompare = index == Count - 1 || sortedList[index + 1].CompareTo(element) >= 0;
            if (insertCase)
            {
                nextCompare = sortedList[index].CompareTo(element) >= 0;
            }

            return previousCompare && nextCompare;
        }

        public IEnumerator<T> GetEnumerator() => sortedList.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
