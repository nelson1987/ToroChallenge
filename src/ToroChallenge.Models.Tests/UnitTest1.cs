using NUnit.Framework;

namespace ToroChallenge.Models.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
        public void TestComErro()
        {
            Assert.Fail();
        }
    }
}