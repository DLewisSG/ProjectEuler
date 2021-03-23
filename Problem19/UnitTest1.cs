using NUnit.Framework;
using ProjectEulerProblem19;
using System;

namespace CountSundaysTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Count_Sundays_From_1901_To_2000()
        {
            int expected = 171;
            var start = new DateTime(1901, 1, 1);
            var end = new DateTime(2000, 12, 31);
            var result = CountSundays.Solve(start, end);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Count_Sundays_From_1998_To_2021()
        {
            int expected = 39;
            var start = new DateTime(1998, 7, 6);
            var end = new DateTime(2021, 3, 22);
            var result = CountSundays.Solve(start, end);
            Assert.AreEqual(expected, result);
        }
    }
}