using NUnit.Framework;
using Tyuiu.LeushinP.Sprint5.Task7.V16.Lib;
namespace Tyuiu.LeushinP.Sprint5.Task7.V16.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void LoadDataAndSave()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V16.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}