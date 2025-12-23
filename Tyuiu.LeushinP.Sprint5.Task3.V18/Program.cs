using Tyuiu.LeushinP.Sprint5.Task3.V18.Lib;
namespace Tyuiu.LeushinP.Sprint5.Task3.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Леушин П. С. | Смартб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнила: Леушин П. С. | Смартб-25-1                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("x = " + x);



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string bo = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + bo);
            Console.WriteLine(" Создан!");
            Console.ReadKey();
        }
    }
}