using Tyuiu.GaberkornEL.Sprint2.Task7.V12.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнил: Габеркорн Егор Леонидович | АСОиУб-25-1";
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* Спринт #2                                                            *");
        Console.WriteLine("* Тема:                                                                *");
        Console.WriteLine("* Задание #7                                                           *");
        Console.WriteLine("* Вариант #12                                                          *");
        Console.WriteLine("* Выполнил: Габеркорн Егор Леонидович  | АСОиУб-25-1                   *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("*                                                                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
        Console.WriteLine("************************************************************************");

        Console.WriteLine("Введите значение X: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение Y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        bool res = ds.CheckDotInShadedArea(x, y);


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        if (res)
        {
            Console.WriteLine("Точка находится в заштрихованной области");
        }
        else
        {
            Console.WriteLine("Точка не находится в заштрихованной области");

        }
        Console.ReadLine();
    }
}
