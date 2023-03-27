using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace IntArray
{
    public class ExceptionsFacts
    {
        [Fact]
        public void IndexerExeceptionsWork()
        {
            var list = new List<int> { 1, 2 };
            Assert.Throws<ArgumentOutOfRangeException>(() => list[2]);
            Assert.Throws<ArgumentOutOfRangeException>(() => list[2] = 3);
            var readOnlylist = new ReadOnlyList<int>(list);
            Assert.Throws<NotSupportedException>(() => readOnlylist[1] = 3);
        }

        [Fact]
        public void CopyToMethodExceptionsWork()
        {
            var list = new List<object> { 1, '2' };
            object[] array = null;
            Assert.Throws<ArgumentNullException>(() => list.CopyTo(array, 0));
            array = new object[1];
            Assert.Throws<ArgumentOutOfRangeException>(() => list.CopyTo(array, -1));
            Assert.Throws<ArgumentException>(() => list.CopyTo(array, 0));
        }

        [Fact]
        public void InsertMethodExeceptionsWork()
        {
            var list = new List<int> { 1, 2 };
            Assert.Throws<ArgumentOutOfRangeException>(() => list.Insert(2, 3));
            var readOnlylist = new ReadOnlyList<int>(list);
            Assert.Throws<NotSupportedException>(() => readOnlylist.Insert(1, 3));
        }
    }
}
