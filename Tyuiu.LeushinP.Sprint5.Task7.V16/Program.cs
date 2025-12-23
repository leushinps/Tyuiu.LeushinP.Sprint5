using Tyuiu.LeushinP.Sprint5.Task7.V16.Lib;
namespace Tyuiu.LeushinP.Sprint5.Task7.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Леушин П. С. | Смартб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Задание #7                                                            *");
            Console.WriteLine("* Вариант #16                                                            *");
            Console.WriteLine("* Выполнила: Леушин П. С. | Смартб-25-1                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Файл находится по пути ...\\OutPutDataFileTask7V16.txt");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            ds.LoadDataAndSave(@"C:\DataSprint5\InPutDataFileTask7V16.txt");
            string text = File.ReadAllText(Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V16.txt" }));
            Console.WriteLine(text);



        }


    }



}