using System;

namespace IntArray
{
    class SortedIntArray : IntArray
    {
        public override int this[int index]
        {
            set
            {
                if (Belongs(index, value, false))
                {
                   intArray[index] = value;
                }
            }
        }

        public override void Add(int element)
        {
            for (int i = 0; i < Count; i++)
            {
                if (Belongs(i, element, true))
                {
                    base.Insert(i, element);
                    return;
                }
            }

            base.Add(element);
        }

        public override void Insert(int index, int element)
        {
            if (Belongs(index, element, true))
            {
                base.Insert(index, element);
            }
        }

        public bool Belongs(int index, int element, bool insertCase)
        {
            int past = index == 0 ? int.MinValue : intArray[index - 1];
            int next = index == Count - 1 ? int.MaxValue : intArray[index + 1];
            if (insertCase)
            {
                next = intArray[index];
            }

            return element >= past && element <= next;
        }
    }
}