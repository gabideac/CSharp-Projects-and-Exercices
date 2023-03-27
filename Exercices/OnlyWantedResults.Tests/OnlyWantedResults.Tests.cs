using System;
using Xunit;

namespace OnlyWantedResults.Tests
{
    public class TestProgram
    {
        [Fact]
        public void BuildOperations_InputSmallNumbersThatDontMach_ShouldReturnNA()
        {
            Assert.Equal("N/A", Program.BuildOperations(4, 3));
        }

        [Fact]
        public void BuildOperations_InputSmallNumbers_ShouldReturnOneCorrectOperation()
        {
            Assert.Equal("1 + 2 = 3", Program.BuildOperations(2, 3));
        }

        [Fact]
        public void BuildOperations_InputBiggerNumbers_ShouldReturnTwoCorrectOperations()
        {
            Assert.Equal("1 + 2 + 3 + 4 - 5 = 5\n" +
                "1 - 2 - 3 + 4 + 5 = 5", Program.BuildOperations(5, 5));
        }

        [Fact]
        public void BuildOperations_InputBiggerNumbers_ShouldReturnNA()
        {
            Assert.Equal("N/A", Program.BuildOperations(10, 44));
        }

        [Fact]
        public void BuildOperations_InputANegativeNumber_ShouldReturnCorrectOPerations()
        {
            Assert.Equal("1 + 2 + 3 - 4 - 5 = -3\n" +
                "1 - 2 - 3 - 4 + 5 = -3", Program.BuildOperations(5, -3));
        }
    }
}
