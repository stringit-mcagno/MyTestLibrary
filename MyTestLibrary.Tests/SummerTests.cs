using NUnit.Framework;
using MyTestLibrary;

namespace MyTestLibrary.Tests
{
    public class SummerTests
    {
        
        [Test]
        public void Sum_returns_sum_of_operands()
        {
            var summer = new Summer();
            int sum = summer.Sum(1, 2);
            Assert.AreEqual(3, sum);

        }
        
        [Test]
        public void Subtract_returns_sum_of_operands()
        {
            var summer = new Summer();
            int difference = summer.Subtract(3, 2);
            Assert.AreEqual(1, difference);

        }
    }
}