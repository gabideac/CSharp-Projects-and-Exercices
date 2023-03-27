using System;
using Xunit;

namespace IntArray
{
    public class SortedIntArrayFacts
    {
        [Fact]
        public void ArrayIsSortedAfterAddingElements()
        {
            var sortedIntArray = new SortedIntArray();
            sortedIntArray.Add(1);
            sortedIntArray.Add(3);
            sortedIntArray.Add(2);
            Assert.Equal(1, sortedIntArray[0]);
            Assert.Equal(2, sortedIntArray[1]);
            Assert.Equal(3, sortedIntArray[2]);
        }

        [Fact]
        public void CanInsertElementOnlyInRightPlace()
        {
            var sortedIntArray = new SortedIntArray();
            sortedIntArray.Add(1);
            sortedIntArray.Add(4);
            sortedIntArray.Insert(1, 3);
            sortedIntArray.Insert(1, 0);
            Assert.Equal(3, sortedIntArray[1]);
        }

        [Fact]
        public void CanSetElementOnlyInRightPlace()
        {
            var sortedIntArray = new SortedIntArray();
            sortedIntArray.Add(1);
            sortedIntArray.Add(3);
            sortedIntArray.Add(3);
            sortedIntArray[1] = 2;
            sortedIntArray[1] = 4;
            Assert.Equal(2, sortedIntArray[1]);
        }
    }
}
