using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace IntArray
{
    public class ListFacts
    {
        [Fact]
        public void CanAddElementsOfDifferentDataTypeToSameArray()
        {
            var list = new List<object>();
            int zero = 0;
            list.Add(zero);
            list.Add("zero");
            list.Add(0.001);
            list.Add('0');
            Assert.Equal(0, list[0]);
            Assert.Equal("zero", list[1]);
            Assert.Equal(0.001, list[2]);
            Assert.Equal('0', list[3]);
        }

        [Fact]
        public void GetElementHavingTheOriginalType()
        {
            var list = new List<object>();
            list.Add(1);
            Assert.IsType<int>(list[0]);
        }

        [Fact]
        public void CanDeclareAnObjectArrayWithMultipleObjects()
        {
            var list = new List<object> { '1', "one", 1 };
            Assert.Equal('1', list[0]);
        }

        [Fact]
        public void CheckMoveNextWithAnEmptyObjectArray()
        {
            var list = new List<object>();
            var objectEnumerator = list.GetEnumerator();
            Assert.False(objectEnumerator.MoveNext());
        }

        [Fact]
        public void CheckLoopThroughAnArrayWorksUsingObjectEnumeratorMethods()
        {
            var list = new List<object> { 1, "two", '3' };
            var objectEnumerator = list.GetEnumerator();
            objectEnumerator.MoveNext();
            Assert.Equal(1, objectEnumerator.Current);
            objectEnumerator.MoveNext();
            Assert.Equal("two", objectEnumerator.Current);
            objectEnumerator.MoveNext();
            Assert.Equal('3', objectEnumerator.Current);
            Assert.False(objectEnumerator.MoveNext());
        }

        [Fact]
        public void CanCopyListElementsToOtherArrayAtGivenIndex()
        {
            var list = new List<object> { 1, "two", '3' };
            object[] array = new object[4];
            array[0] = 2;
            list.CopyTo(array, 1);
            object[] completeArray = { 2, 1, "two", '3' };
            Assert.Equal(array, completeArray);
        }
    }
}
