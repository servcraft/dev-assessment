using NUnit.Framework;
using Web.Controllers;

namespace TestProject1
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
        public void Controller()
        {
            var obj = new AuthController();
            Assert.AreEqual(obj, obj);
        }
    }
}