using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GaberkornEL.Sprint2.Task1.V17.Lib
{
    public class DataService : ISprint2Task1V17

    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            a = 125; b = 123; c = 455; d = 321;
            res[0] = (a + b + 528) == (c + d) | false;
            res[1] = (a + b) != (c + d) & false;
            res[2] = (a + b) < (c + d) || false;
            res[3] = (a + b + 529) > (c + d) && true;
            res[4] = !((a + b + 529) <= (c + d));
            res[5] = (a + b) >= (c + d) ^ true; //false
            return res;
        }
    }
}