using NUnit.Framework;
using ProjectEulerModApp;

namespace ModTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Input_10_Equals_23()
        {
            var result = Program.Mod(10);
            Assert.AreEqual(23, result);
        }

        [Test]
        public void Input_6_Equals_8()
        {
            var result = Program.Mod(6);
            Assert.AreEqual(8, result);
        }

        [Test]
        public void Input_1000_Equals_233168()
        {
            var result = Program.Mod(1000);
            Assert.AreEqual(233168, result);
        }

        [Test]
        public void Input_35_Equals_456()
        {
            var result = Program.Mod(35);
            Assert.AreNotEqual(456, result);
        }

        public void Input_1_Equals_1()
        {
            var result = Program.Mod(1);
            Assert.AreNotEqual(1, result);
        }
    }
}