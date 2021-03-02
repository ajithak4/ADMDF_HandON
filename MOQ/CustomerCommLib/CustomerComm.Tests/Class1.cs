using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerCommLib;
using Moq;

namespace CustomerCommTests
{
    [TestFixture]
    public class Class1
    {
        Mock<IMailSender> mock;
        CustomerComm obj;
        [SetUp]
        public void init()
        {
            mock = new Mock<IMailSender>(MockBehavior.Strict);
        }


        [Test]
        [TestCase("abc@gmail.com", "hello",true)]
        public void Setup(string a,string b,bool expected)
        {
           
            mock.Setup(p => p.SendMail(a,b)).Returns(expected);

            obj = new CustomerComm(mock.Object);
            bool actual=obj.SendMailToCustomer(a,b);
            Assert.AreEqual(actual, expected);
        }


    }
}
