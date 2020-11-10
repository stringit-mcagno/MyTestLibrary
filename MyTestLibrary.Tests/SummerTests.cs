using NUnit.Framework;
using MyTestLibrary;

namespace MyTestLibrary.Tests
{
    public class SummerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Sum_returns_sum_of_operands()
        {
            var summer = new Summer();
            int sum = summer.Sum(1, 2);
            Assert.AreEqual(3, sum);

        }
    }
}