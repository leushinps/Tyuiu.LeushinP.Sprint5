using NUnit.Framework;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using Tyuiu.LeushinP.Sprint5.Task2.V19.Lib;

namespace Tyuiu.LeushinP.Sprint5.Task2.V19.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        private DataService ds;

        [SetUp]
        public void Setup()
        {
            ds = new DataService();
        }

        [Test]
        public void ValidSaveToFileTextData()
        {
            int[,] matrix = new int[3, 3]
            {
                { 9, 2, 5 },
                { 8, 8, 2 },
                { 7, 4, 8 }
            };

            string path = ds.SaveToFileTextData(matrix);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            Assert.IsTrue(fileExists);
            string path = @"C:\Users\Pavelon\AppData\Local\Temp\OutPutFileTask2.csv";
        }
    }
}