using Tyuiu.GaberkornEL.Sprint2.Task1.V17.Lib;
namespace Tyuiu.GaberkornEL.Sprint2.Task1.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Габеркорн Егор Леонидович | АСОиУб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Габеркорн Егор Леонидович | АСОиУб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            int a = 135;
            int b = 123;
            int c = 455;
            int d = 321;

            bool[] res = ds.GetLogicOperations(a, b, c, d);
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
        }
    }
}
