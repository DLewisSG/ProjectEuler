using NUnit.Framework;
using ProjectEulerProblem10;

namespace SummationTests
{
    public class PrimesSumTests
    {
        [Test]
        public void Input_First_Primes_In_10_Expect_Sum_17()
        {
            int expected = 17;
            var res = Program.Solve(10);
            Assert.AreEqual(expected, res);
        }

        [Test]
        public void Input_First_Primes_In_100_Expect_Sum_1060()
        {
            int expected = 1060;
            var res = Program.Solve(100);
            Assert.AreEqual(expected, res);
        }

        [Test]
        public void Input_First_Primes_In_2_Million_Expect_Sum_142913828922()
        {
        long expected = 142913828922;
        var res = Program.Solve(2000000);
        Assert.AreEqual(expected, res);
        }
    }
}
