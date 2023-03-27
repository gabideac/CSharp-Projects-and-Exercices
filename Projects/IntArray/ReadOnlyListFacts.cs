using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace IntArray
{
    public class ReadOnlyListFacts
    {
        [Fact]
        public void AllInterogationMethodsReturnCorrectValue()
        {
            var originalList = new List<int> { 0, 1, 2 };
            var readOnlyList = new ReadOnlyList<int>(originalList);
            Assert.Equal(3, readOnlyList.Count);
            Assert.Equal(2, readOnlyList[2]);
            Assert.Equal(1, readOnlyList.IndexOf(1));
            Assert.True(readOnlyList.Contains(2));
        }

        [Fact]
        public void ListCantBeModified()
        {
            var originalList = new List<int> { 0, 1, 2 };
            var readOnlyList = new ReadOnlyList<int>(originalList);
            Assert.Throws<NotSupportedException>(() => readOnlyList[1] = 3);
            Assert.Throws<NotSupportedException>(() => readOnlyList.Add(3));
            Assert.Throws<NotSupportedException>(() => readOnlyList.Clear());
            Assert.Throws<NotSupportedException>(() => readOnlyList.Insert(1, 3));
            Assert.Throws<NotSupportedException>(() => readOnlyList.Remove(1));
            Assert.Throws<NotSupportedException>(() => readOnlyList.RemoveAt(1));
        }

        [Fact]
        public void CanCopyListToAnArray()
        {
            var originalList = new List<object> { 1, "two", '3' };
            var list = new ReadOnlyList<object>(originalList);
            object[] array = new object[4];
            array[0] = 2;
            list.CopyTo(array, 1);
            object[] completeArray = { 2, 1, "two", '3' };
            Assert.Equal(completeArray, array);
        }

        [Fact]
        public void CanLoopThroughList()
        {
            var list = new List<object> { 1, "two", '3' };
            var readOnlyList = new ReadOnlyList<object>(list);
            var objectEnumerator = readOnlyList.GetEnumerator();
            objectEnumerator.MoveNext();
            Assert.Equal(1, objectEnumerator.Current);
            objectEnumerator.MoveNext();
            Assert.Equal("two", objectEnumerator.Current);
            objectEnumerator.MoveNext();
            Assert.Equal('3', objectEnumerator.Current);
            Assert.False(objectEnumerator.MoveNext());
        }
    }
}
