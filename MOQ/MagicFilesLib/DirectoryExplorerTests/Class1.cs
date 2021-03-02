using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MagicFilesLib;
using Moq;

namespace DirectoryExplorerTests
{
    [TestFixture]
    public class Class1
    {
        Mock<IDirectoryExplorer> mock;
        DirectoryExplorer obj;
        List <string> files;
        private readonly string _file1 = "file.txt";

        private readonly string _file2 = "file2.txt";
        [SetUp]
        public void init()
        {
           files = new List<string> { _file1,_file2 };
            mock = new Mock<IDirectoryExplorer>(MockBehavior.Strict);
        } 
        

        [Test]
        [TestCase("/Home/test")]

        public  void set(string path)
        {
          
            mock.Setup(p => p.GetFiles(path)).Returns(files);

            var actual= mock.Object.GetFiles(path);

            Assert.AreEqual(actual.Count,2);
            Assert.IsNotNull(actual);
            CollectionAssert.Contains( actual, _file1);
            Assert.IsTrue(actual.Contains(_file1));

        }
    }
}
