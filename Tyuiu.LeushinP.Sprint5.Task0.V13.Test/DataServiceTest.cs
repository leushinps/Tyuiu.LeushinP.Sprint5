using NUnit.Framework;

using Tyuiu.LeushinP.Sprint5.Task0.V13;

namespace Tyuiu.LeushinP.Sprint5.Task0.V13.Test
{
    [TestFixture]
    public sealed class DataServiceTest
    {
        [Test]
        public void CheckedExistsFile()
        {
            string path =  @"C:\Users\Pavelon\AppData\Local\Temp\OutPutFileTask0.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}