using System;
using System.Collections;
using System.Collections.Generic;

namespace IntArray
{
    class ReadOnlyList<T> : IList<T>
    {
        private readonly IList<T> readOnlyList;

        public ReadOnlyList(List<T> list)
        {
            readOnlyList = list;
        }

        public int Count => readOnlyList.Count;

        public bool IsReadOnly => true;

        public T this[int index]
        {
            get
            {
                return readOnlyList[index];
            }

            set
            {
                throw new NotSupportedException();
            }
        }

        public bool Contains(T item) => readOnlyList.Contains(item);

        public void Add(T item) => throw new NotSupportedException();

        public int IndexOf(T item) => readOnlyList.IndexOf(item);

        public void Insert(int index, T item) => throw new NotSupportedException();

        public void Clear() => throw new NotSupportedException();

        public bool Remove(T item) => throw new NotSupportedException();

        public void RemoveAt(int index) => throw new NotSupportedException();

        public void CopyTo(T[] array, int arrayIndex) => readOnlyList.CopyTo(array, arrayIndex);

        public IEnumerator<T> GetEnumerator() => readOnlyList.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}