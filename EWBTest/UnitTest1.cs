using System;
using Xunit;

namespace EWBTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var a = 5;
            var b = 6;
            var c = a + b;
            Assert.True(c == 11);
        }
    }
}
