using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace Tyuiu.LeushinP.Sprint5.Task1.V12.Test
{
    public class DataServiceTest
    {
        public void TestMethod1()
        {
            int i = 0;
            double numerator = 5 * i + 2.5;
            double denominator = Math.Sin(i) - 2;
            double result = Math.Round((numerator / denominator) + 2, 2);
            double wait = 0.75;
            Assert.AreEqual(wait, result);
            string path = @"C:\Users\Pavelon\source\repos\Tyuiu.LeushinP.Sprint5\Tyuiu.LeushinP.Sprint5.Task2.V12\bin\Debug\net8.0OutPutFileTask2.txt";
        }
    }
}