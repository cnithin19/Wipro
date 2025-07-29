using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day8;
using NUnit.Framework;
namespace Day8Testing
{
    [TestFixture]
    public class DemoTest
    {
        [Test]
        public void TestDemo()
        {
            Demo demo = new Demo();
            Assert.AreEqual("Hello...", demo.sayHello());
            
        }
        //[Test]
        //public void TestSayBye()
        //{
        //    Demo demo1 = new Demo();
        //    demo1.sayBye();
        //    Assert.AreEqual("Bye...");
        //}

    }
}
