using Tyuiu.BudykovaMM.Sprint3.Task2.V10.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 │ Выполнила: Будыкова М. М. │ ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
        Console.WriteLine("* Вариант #10                                                             *");
        Console.WriteLine("* Выполнила: Будыкова Мадина Маратовна │ ПИНб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу используя цикл do...while,                           *");
        Console.WriteLine("* которая вычисляет произведение ряда по формуле, при t=1.                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int value = 1;
        int startValue = 1;
        int stopValue = 13;

        Console.WriteLine("Переменная K = " + value);
        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Сумма ряда = " + ds.GetMultiplySeries(value, startValue, stopValue));
        Console.ReadKey();
    }
}