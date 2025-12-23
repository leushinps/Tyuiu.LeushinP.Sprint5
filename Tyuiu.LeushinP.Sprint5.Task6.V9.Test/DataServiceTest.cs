using NUnit.Framework;
using Tyuiu.LeushinP.Sprint5.Task6.V9.Lib;

namespace Tyuiu.LeushinP.Sprint5.Task6.V9.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V9.txt";

            FileInfo fileInfo = new FileInfo(path);
            int wait = 2;
            var res = ds.LoadFromDataFile(path);
            Assert.AreEqual(wait, res);

        }
    }
}