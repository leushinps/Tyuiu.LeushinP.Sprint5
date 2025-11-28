using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using Tyuiu.LeushinP.Sprint5.Task0.V13.Test;
namespace Tyuiu.LeushinP.Sprint5.Task0.V13;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = ("Спринт #5 | Выполнил: Леушин Павел Сергеевич | Смартб-25-1");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #13                                                             *");
        Console.WriteLine("* Выполнил: Леушин Павел Сергеевич | Смартб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дано выражение, вычислить его значение при x = 5, результат сохранить   *");
        Console.WriteLine("* в текстовый файл OutPutFileTask0.txt и вывести на консоль. Округлить    *");
        Console.WriteLine("* до трёх знаков после запятой.                                           *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int x = 5;

        Console.WriteLine("x: " + x);
        string filePath = ds.SaveToFileTextData(x);
        string result = File.ReadAllText(filePath);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Файл: " + filePath);
        Console.WriteLine("Создан!");
        Console.WriteLine("Результат вычисления z: " + result);
    }
}