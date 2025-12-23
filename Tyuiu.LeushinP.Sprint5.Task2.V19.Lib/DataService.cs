using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.LeushinP.Sprint5.Task2.V19.Lib
{
    public class DataService : ISprint5Task2V19
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                File.Delete(path);
            }

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j == cols - 1)
                        File.AppendAllText(path, matrix[i, j].ToString());
                    else
                        File.AppendAllText(path, matrix[i, j].ToString() + ";");
                }
                File.AppendAllText(path, Environment.NewLine);
            }

            return path;
        }
    }
}