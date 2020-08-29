using System;
using Xunit;
using demo;

namespace demo.tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Assert.Equal(true, false);
            Assert.Equal(Program.x, 1);
        }
    }
}
