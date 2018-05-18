using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileReader.ConsoleApp;

namespace FileReader.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCreateFileMethod()
        {
            //<--- Arrange
            CustomFileReader cfr = new CustomFileReader();
            string path = @"c:\temp\MyTest.txt";

            //<--- Act
            string actual = cfr.CreateFile(path);

            //<--- Assert
            Assert.AreEqual(path, actual);
        }

        [TestMethod]
        public void TestReadFileMethod()
        {
            //<--- Arrange
            CustomFileReader cfr = new CustomFileReader();
            string path = @"c:\temp\MyTest.txt";

            //<--- Act
            string actual = cfr.ReadFile(path);

            //<--- Assert
            Assert.AreEqual(path, actual);
        }
    }
}
