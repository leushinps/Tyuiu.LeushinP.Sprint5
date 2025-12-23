using Tyuiu.LeushinP.Sprint5.Task6.V9.Lib;

namespace Tyuiu.LeushinP.Sprint5.Task6.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Леушин П. С. | Смартб-25-1";

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                         *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                                  *");
            Console.WriteLine("* Задание #6                                                                        *");
            Console.WriteLine("* Вариант #9                                                                        *");
            Console.WriteLine("* Выполнил: Леушин П. С. | Смартб-25-1                                              "); 
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask4V0.txt (файл взять из архива согласно *");
            Console.WriteLine("* вашему варианту. Создать папку в ручную С:\\DataSprint5\\ и скопировать в неё     *");
            Console.WriteLine("* файл) в котором есть набор символьных данных. Найти количество слов длиной три    *");
            Console.WriteLine("* символа в заданной строке.                                                        *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask6V9.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");


            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();

        }
    }
}