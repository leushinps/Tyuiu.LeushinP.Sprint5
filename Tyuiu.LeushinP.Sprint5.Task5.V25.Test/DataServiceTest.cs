using NUnit.Framework;
using Tyuiu.LeushinP.Sprint5.Task5.V25.Lib;
namespace Tyuiu.LeushinP.Sprint5.Task5.V25.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void LoadFromDataFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V25.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}

