using System;
using Tyuiu.GaberkornEL.Sprint2.Task4.V27.Lib;

namespace Tyuiu.GaberkornEL.Sprint2.Task4.V27
{
    public class Class1
    {
        public static void Main()
        {
            DataService ds = new DataService();
            double result;

            Console.Title = "Task:..v| Габеркорн Егор Леонидович, АСОиУб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Габеркорн Егор Леонидович | АСОиУб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие: z = x-10>y+2 ? x*((y+2)/(x-1))**x) : y*y-2/x                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.Write("* x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("* y = ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");

            { 
                result = ds.Calculate(x, y);
            }
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* z = {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}