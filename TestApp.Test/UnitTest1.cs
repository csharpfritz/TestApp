using System;
using Xunit;

namespace TestApp.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        [Fact]
        public void TestFail()
        {

            Assert.True(true, "True is not false");

        }

        [Fact]
        public void TestSum()
        {

            Assert.Equal(4, TestApp.Console.Program.Sum(2, 2));

        }

        [Fact]
        public void TestSum2()
        {
            Assert.Equal(5, TestApp.Console.Program.Sum(2, 3));
        }


    }
}
