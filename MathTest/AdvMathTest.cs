using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Maths;

namespace MathTest
{
    public class AdvMathTest
    {
        [Fact]
        public void TestArea()
        {

            var math = new AdvMath();
            var result = math.CalcArea(5, 5);
            Assert.True(result == 25);
        }

        [Fact]
        public void TestAvg()
        {
            var math = new AdvMath();
            var lNums = new List<double> { 1, 2, 3, 4, 5 };
            var result = math.CalcAvg(lNums);
            Assert.True(result == 3);
        }

        [Fact]
        public void TestSq()
        {

            var math = new AdvMath();
            var result = math.CalcNumSq(5);
            Assert.True(result == 25);
        }

        [Fact]
        public void TestSqrt()
        {

            var math = new AdvMath();
            var result = math.CalcNumSqrt(25);
            Assert.True(result == 5);
        }


        [Fact]
        public void TestPT()
        {

            var math = new AdvMath();
            var result = math.CalcPT(3, 4);
            Assert.True(result == 5);
        }
    }
}
