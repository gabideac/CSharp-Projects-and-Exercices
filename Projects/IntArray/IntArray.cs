using System;

namespace IntArray
{
    class IntArray
    {
        protected readonly List<int> intArray;

        public IntArray() => intArray = new List<int>();

        public int Count => intArray.Count;

        public virtual int this[int index]
        {
            get => intArray[index];
            set => intArray[index] = value;
        }

        public bool Contains(int element) => intArray.Contains(element);

        public virtual void Add(int element) => intArray.Add(element);

        public int IndexOf(int element) => intArray.IndexOf(element);

        public virtual void Insert(int index, int element) => intArray.Insert(index, element);

        public void Clear() => intArray.Clear();

        public void Remove(int element) => intArray.Remove(element);

        public void RemoveAt(int index) => intArray.RemoveAt(index);
    }
}
