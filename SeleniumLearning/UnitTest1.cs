using NUnit.Framework;

namespace SeleniumLearning
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            TestContext.Progress.WriteLine("setup method execution");
        }

        [Test]
        public void Test1()
        {
            TestContext.Progress.WriteLine("this is test numer 1");
        }

        [Test]
        public void Test2() 
        {
            TestContext.Progress.WriteLine("this is test numer 2");
        }

        [TearDown]
        public void CloseBrowser() 
        {
            TestContext.Progress.WriteLine("tear down method");
        }
    }
}