using System;
using Xunit;

namespace study_jenkins.Test
{
    public class SimpleMathTest
    {
        [Fact]
        public void AddTest()
        {
            var res = Models.SimpleMath.Add(1, 2);
            Assert.True(3 == res);
        }

        [Fact]
        public void SubtractTest()
        {
            var res = Models.SimpleMath.Subtract(10, 3);
            Assert.True(7 == res);
        }

        [Fact]
        public void MultiplyTest()
        {
            var res = Models.SimpleMath.Multiply(7, 6);
            Assert.Equal(42, res);
        }

        [Fact]
        public void DivideTest()
        {
            var res = Models.SimpleMath.Divide(21, 3);
            Assert.Equal(7, res);
        }

        [Fact]
        public void RemainderTest()
        {
            var res = Models.SimpleMath.Remainder(19, 4);
            Assert.Equal(3, res);
        }
    }
}
