using NUnit.Framework;

namespace Tyuiu.LeushinP.Sprint5.Task4.V16.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\Users\Pavelon\AppData\Local\Temp\OutPutFileTask3.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}