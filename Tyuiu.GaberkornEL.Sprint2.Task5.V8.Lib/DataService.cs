using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GaberkornEL.Sprint2.Task5.V8.Lib
{
    public class DataService : ISprint2Task5V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            string res;
            switch (m)
            {
                case 1:
                    if (n > 1)
                    {
                        n--;
                    }
                    else
                    {
                        n = 31;
                    }
                    break;
                case 2:
                    if (n > 1)
                    {
                        n--;
                    }
                    else
                    {
                        n = 31;
                    }
                    break;
                case 3:
                    if (n > 1)
                    {
                        n--;
                    }
                    else
                    {
                        n = 28;
                    }
                    break;
                case 4:
                    if (n > 1)
                    {
                        n--;
                    }
                    else
                    {
                        n = 31;
                    }
                    break;
                case 5:
                    if (n > 1)
                    {
                        n--;
                    }
                    else
                    {
                        n = 30;
                    }
                    break;
                case 6:
                    if (n > 1)
                    {
                        n--;
                    }
                    else
                    {
                        n = 31;
                    }
                    break;
                case 7:
                    if (n > 1)
                    {
                        n--;
                    }
                    else
                    {
                        n = 30;
                    }
                    break;
                case 8:
                    if (n > 1)
                    {
                        n--;
                    }
                    else
                    {
                        n = 31;
                    }
                    break;
                case 9:
                    if (n > 1)
                    {
                        n--;
                    }
                    else
                    {
                        n = 31;
                    }
                    break;
                case 10:
                    if (n > 1)
                    {
                        n--;
                    }
                    else
                    {
                        n = 30;
                    }
                    break;
                case 11:
                    if (n > 1)
                    {
                        n--;
                    }
                    else
                    {
                        n = 31;
                    }
                    break;
                case 12:
                    if (n > 1)
                    {
                        n--;
                    }
                    else
                    {
                        n = 30;
                    }
                    break;






            }
            string x = Convert.ToString(n);
            string y = Convert.ToString(m);
            if (n < 10 && m < 10)
            {
                return "0" + x + '.' + "0" + y;

            }
            else
            {
                if (n < 10)
                {
                    return "0" + x + '.' + y;
                }
                else
                {
                    if (m < 10)
                    {
                        return x + "." + "0" + y;
                    }
                    else
                    {
                        return x + '.' + y;
                    }
                }
            }
        }
    }
}