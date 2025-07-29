using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day8;
using NUnit;
using Moq;

namespace Day8Testing
{
    [TestFixture]
    internal class MonkTest
    {
        [Test]
        public void TestShow1()
        {
            Mock<IMonk> mockdetails = new Mock<IMonk>();
            mockdetails.Setup(x => x.Show1()).Returns("Changed show1");
            //Assert.That(mockdetails.Object.Show1(), Is.EqualTo("Changed show1"));
            Assert.AreEqual("Changed show1", mockdetails.Object.Show1());


        }
        [Test]
        public void TestShow2()
        {
            Mock<IMonk> mockdetails = new Mock<IMonk>();
            mockdetails.Setup(x => x.Show2()).Returns("Changed show2");
            Assert.That(mockdetails.Object.Show2(), Is.EqualTo("Changed show2"));
        }
    }
}
