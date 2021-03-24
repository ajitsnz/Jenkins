using NUnit.Framework;
using System;

namespace Jenkins
{
    public class TestCase
    {

        [Test]
        public void Test1()
        {
            TestContext.WriteLine("Test Context : Test case Test1");
            Console.WriteLine("Console : Test case Test1");
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            TestContext.WriteLine("Test Context : Test case Test1");
            Console.WriteLine("Console : Test case Test1");
            Assert.Pass();
        }


        [Test]
        public void Test3()
        {
            TestContext.WriteLine("Test Context : Test case Test1");
            Console.WriteLine("Console : Test case Test1");
            Assert.Pass();
        }


        [Test]
        public void Test4()
        {
            TestContext.WriteLine("Test Context : Test case Test1");
            Console.WriteLine("Console : Test case Test1");
            Assert.Pass();
        }



    }
}