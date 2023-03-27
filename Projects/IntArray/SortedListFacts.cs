using System;
using Xunit;

namespace IntArray
{
    public class SortedListFacts
    {
        [Fact]
        public void CanAddElementsOnlyInPorperPlace()
        {
            var sortedList = new SortedList<int>();
            sortedList.Add(3);
            sortedList.Add(1);
            sortedList.Add(2);
            sortedList.Add(0);
            Assert.Equal(0, sortedList[0]);
            Assert.Equal(1, sortedList[1]);
            Assert.Equal(2, sortedList[2]);
            Assert.Equal(3, sortedList[3]);
        }

        [Fact]
        public void CanOnlyInsertElementsInProperPlace()
        {
            var sortedList = new SortedList<char> { '1', '0', '3' };
            sortedList.Insert(2, '2');
            Assert.Equal('2', sortedList[2]);
        }

        [Fact]
        public void CanOnlySetElementsInProperPlace()
        {
            var sortedList = new SortedList<string> { "Andrei", "Ionut", "Marius" };
            sortedList[1] = "Darius";
            sortedList[1] = "Silviu";
            Assert.Equal("Darius", sortedList[1]);
        }
    }
}
