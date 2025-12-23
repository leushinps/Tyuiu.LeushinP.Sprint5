using Tyuiu.LeushinP.Sprint5.Task5.V25.Lib;
namespace Tyuiu.LeushinP.Sprint5.Task5.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Леушин П. С. | Смартб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                      *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #25                                                              *");
            Console.WriteLine("* Выполнил: Выполнил: Леушин П. С. | Смартб-25-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask5V25.txt";
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}