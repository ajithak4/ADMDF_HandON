using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using PlayermanagerLib;
namespace TestClass
{
    [TestFixture]
    public class Class1
    {
        Mock<IPlayerMapper> mock;
        Player p;
        [SetUp]
        public void Init()
        {
            mock = new Mock<IPlayerMapper>();
        }

        [Test]
        [TestCase("player", 20, "India", 50)]
        //[ExpectedException(typeof(ArgumentException)]
        public void Test(string name, int age, string country, int noOfMatches)
        {

            mock.Setup(p => p.IsPlayerNameExistsInDb(name)).Returns(false);

            Player player = Player.RegisterNewPlayer(name, mock.Object);

            Assert.That(name, Is.EqualTo(player.Name));
            Assert.That(23, Is.EqualTo(player.Age));
            Assert.That("India", Is.EqualTo(player.Country));
            Assert.That(30, Is.EqualTo(player.NoOfMatches));
        }

        [Test]
        [TestCase(" ", 21, "India", 50)]
        [TestCase(null, 21, "India", 50)]
        public void TestException(string name, int age, string country, int noOfMatches)
        {
            // mock.Setup(p => p.IsPlayerNameExistsInDb(name)).Returns(true);

            Assert.Throws<ArgumentException>(() => Player.RegisterNewPlayer(name, mock.Object));

        }
    }
}
