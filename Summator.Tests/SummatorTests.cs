using NUnit.Framework;

namespace Summator.Tests
{
    public class SummatorTests
    {
        [Test]
        public void Test_Sum_TwoPossitiveNumbers()
        {
            long result = Summator.Sum(new int[] { 5, 7 });

            Assert.That(result == 12);
        }
        [Test]
        public void Test_Sum_OnePossitiveNumber()
        {
            long result = Summator.Sum(new int[] { 5 });

            Assert.That(result == 5);
        }
        [Test]
        public void Test_Sum_TwoNegativeNumber()
        {
            long result = Summator.Sum(new int[] { -7, -9 });

            Assert.That(result == -16);
        }
        [Test]
        public void Test_Sum_EmptyArray()
        {
            long result = Summator.Sum(new int[] { });

            Assert.That(result == 0);
        }
        [Test]
        public void Test_Sum_BigValues()
        {
            long result = Summator.Sum(new int[] { 2000000000, 2000000000, 2000000000 });

            Assert.AreEqual(result, 6000000000);
        }
        [Test]
        public void Test_Average_TwoPossitiveNumbers()
        {
            long result = Summator.Average(new int[] { 5 , 7 });
            long actual= 6;

            Assert.That(result == actual);
        }
    }
}