using System;
using System.Collections.Generic;
using Xunit;

namespace IntArray
{
    public class IntArrayFacts
    {
        [Fact]
        public void CanCountElemets()
        {
            var array = new IntArray();
            array.Add(5);
            array.Add(3);
            array.Add(2);
            array.Remove(5);
            Assert.Equal(2, array.Count);
        }

        [Fact]
        public void CanAddElemets()
        {
            var array = new IntArray();
            array.Add(4);
            Assert.Equal(4, array[0]);
        }

        [Fact]
        public void CanGetElementFromIndex()
        {
            var array = new IntArray();
            array.Add(5);
            Assert.Equal(5, array[0]);
        }

        [Fact]
        public void CanSetElementOnGivenIndex()
        {
            var array = new IntArray();
            array.Add(1);
            array[0] = 5;
            Assert.Equal(5, array[0]);
        }

        [Fact]
        public void CanCheckIfArrayContainsElement()
        {
            var array = new IntArray();
            array.Add(5);
            Assert.True(array.Contains(5));
            Assert.False(array.Contains(2));
        }

        [Fact]
        public void CanGetIndexFromElement()
        {
            var array = new IntArray();
            array.Add(5);
            Assert.Equal(0, array.IndexOf(5));
            Assert.Equal(-1, array.IndexOf(2));
        }

        [Fact]
        public void CanInsertElemntInArray()
        {
            var array = new IntArray();
            array.Add(0);
            array.Add(2);
            array.Add(3);
            array.Insert(1, 1);
            Assert.Equal(1, array[1]);
            Assert.Equal(0, array[0]);
            Assert.Equal(2, array[2]);
        }

        [Fact]
        public void CanDeleteAllElemetsFromArray()
        {
            var array = new IntArray();
            array.Add(0);
            array.Add(2);
            array.Clear();
            Assert.Equal(0, array.Count);
        }

        [Fact]
        public void CanRemoveOneElementFromArray()
        {
            var array = new IntArray();
            array.Add(0);
            array.Add(1);
            array.Add(2);
            array.Remove(1);
            Assert.Equal(2, array[1]);
        }

        [Fact]
        public void CanRemoveElementFromGivenIndex()
        {
            var array = new IntArray();
            array.Add(0);
            array.Add(1);
            array.Add(2);
            array.RemoveAt(1);
            Assert.Equal(2, array[1]);
        }
    }
}
