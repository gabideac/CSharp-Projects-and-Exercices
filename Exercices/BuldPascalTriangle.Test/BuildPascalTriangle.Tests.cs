using System;
using Xunit;

namespace BuildPascalTriangle.Tests
{
    public class TestProgram
    {
        [Fact]
        public void BuildPascalTriangle_NumbersSmallerThanOne_ShouldReturnInvalidNumberError()
        {
            int triangleHight = -1;
            Assert.Equal("Numar invalid!", Program.BuildPascalTriangle(triangleHight));
        }

        [Fact]
        public void BuildPascalTriangle_OneLevelTriangle_ShouldReturnFirstTriangleLine()
        {
            int triangleHight = 1;
            Assert.Equal("1", Program.BuildPascalTriangle(triangleHight));
        }

        [Fact]
        public void BuildPascalTriangle_TwoLevelTriangle_ShouldReturnATwoLevelTriangle()
        {
            int triangleHight = 2;
            Assert.Equal("1\n1 1", Program.BuildPascalTriangle(triangleHight));
        }

        [Fact]
        public void BuildPascalTriangle_ThreeLevelTriangle_ShouldReturnAThreelevelTriangle()
        {
            int triangleHight = 3;
            Assert.Equal("1\n1 1\n1 2 1", Program.BuildPascalTriangle(triangleHight));
        }

        [Fact]
        public void BuildPascalTriangle_FiveLevelTriangle_ShouldReturnFifthTriangleLine()
        {
            int triangleHight = 5;
            Assert.Equal("1\n1 1\n1 2 1\n1 3 3 1\n1 4 6 4 1", Program.BuildPascalTriangle(triangleHight));
        }

        [Fact]
        public void BuildPascalTriangle_TenLevelTriangle_ShouldReturnTenthTriangleLine()
        {
            int triangleHight = 10;
            Assert.Equal("1\n" +
                "1 1\n" +
                "1 2 1\n" +
                "1 3 3 1\n" +
                "1 4 6 4 1\n" +
                "1 5 10 10 5 1\n" +
                "1 6 15 20 15 6 1\n" +
                "1 7 21 35 35 21 7 1\n" +
                "1 8 28 56 70 56 28 8 1\n" +
                "1 9 36 84 126 126 84 36 9 1",
                Program.BuildPascalTriangle(triangleHight));
        }
    }
}
