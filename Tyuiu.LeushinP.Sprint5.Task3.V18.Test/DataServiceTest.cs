using NUnit.Framework;
using System.IO;
using Tyuiu.LeushinP.Sprint5.Task3.V18.Lib;
namespace Tyuiu.LeushinP.Sprint5.Task3.V18.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void TestMethod1()
        {
            string path = @"C:\Users\Pavelon\AppData\Local\Temp\OutPutFileTask3.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}