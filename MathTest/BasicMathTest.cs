using Maths;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MathTest
{
    public class BasicMathTest
    {
        [Fact]
        public void TestAddNum()
        {

            var math = new BasicMath();
            var result = math.AddNum(5, 5);
            Assert.True(result == 10);
        }

        [Fact]
        public void TestSubNum()
        {

            var math = new BasicMath();
            var result = math.SubnNum(10, 3);
            Assert.True(result == 7);
        }

        [Fact]
        public void TestMultNum()
        {

            var math = new BasicMath();
            var result = math.MultNum(5, 2);
            Assert.True(result == 10);
        }

        [Fact]
        public void TestDivNum()
        {

            var math = new BasicMath();
            var result = math.DivNum(10, 5);
            Assert.True(result == 2);
        }
    }
}
