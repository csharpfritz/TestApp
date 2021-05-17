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

            Assert.False(true, "True is not false");

        }
    }
}
