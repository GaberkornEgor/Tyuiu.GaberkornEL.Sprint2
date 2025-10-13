using Tyuiu.NikiforovFA.Sprint2.Task1.V17.Lib;
namespace Tyuiu.NikiforovFA.Sprint2.Task1.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Никифоров Ф. А | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Никифоров Федор Александрович | ПКТб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            int a = 125, b = 123, c = 455, d = 321;
            Console.WriteLine("a = {0}, b = {1}, c = {2}, d = {3}", a, b, c, d);
            Console.WriteLine("* Результат:                                                              *");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(ds.GetLogicOperations(a,b,c,d)[i]);
            }
        }
    }
}
