using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GaberkornEL.Sprint2.Task6.V14.Lib
{
    public class DataService : ISprint2Task6V14
    {
        public string FindDayName(int k, int d)
        {
            if (d == 1)
            {
                switch (k % 7)
                {
                    case 1: return "Понедельник";
                    case 2: return "Вторник";
                    case 3: return "Среда";
                    case 4: return "Четверг";
                    case 5: return "Пятница";
                    case 6: return "Суббота";
                    case 0: return "Воскресенье";
                    default: throw new ArgumentException("Неправильно введен месяц");
                }
            }
            else if (d == 2)
            {
                switch (k % 7)
                {
                    case 1: return "Вторник";
                    case 2: return "Среда";
                    case 3: return "Четверг";
                    case 4: return "Пятница";
                    case 5: return "Суббота";
                    case 6: return "Воскресенье";
                    case 0: return "Понедельник";
                    default: throw new ArgumentException("Неправильно введен месяц");
                }
            }
            else if (d == 3)
            {
                switch (k % 7)
                {
                    case 1: return "Среда";
                    case 2: return "Четверг";
                    case 3: return "Пятница";
                    case 4: return "Суббота";
                    case 5: return "Воскресенье";
                    case 6: return "Понедельник";
                    case 0: return "Вторник";
                    default: throw new ArgumentException("Неправильно введен месяц");
                }
            }
            else if (d == 4)
            {
                switch (k % 7)
                {
                    case 1: return "Четверг";
                    case 2: return "Пятница";
                    case 3: return "Суббота";
                    case 4: return "Воскресенье";
                    case 5: return "Понедельник";
                    case 6: return "Вторник";
                    case 0: return "Среда";
                    default: throw new ArgumentException("Неправильно введен месяц");
                }
            }
            else if (d == 5)
            {
                switch (k % 7)
                {
                    case 1: return "Пятница";
                    case 2: return "Суббота";
                    case 3: return "Воскресенье";
                    case 4: return "Понедельник";
                    case 5: return "Вторник";
                    case 6: return "Среда";
                    case 0: return "Четверг";
                    default: throw new ArgumentException("Неправильно введен месяц");
                }
            }
            else if (d == 6)
            {
                switch (k % 7)
                {
                    case 1: return "Суббота";
                    case 2: return "Воскресенье";
                    case 3: return "Понедельник";
                    case 4: return "Вторник";
                    case 5: return "Среда";
                    case 6: return "Четверг";
                    case 0: return "Пятница";
                    default: throw new ArgumentException("Неправильно введен месяц");
                }
            }
            else
            {
                switch (k % 7)
                {
                    case 1: return "Воскресенье";
                    case 2: return "Понедельник";
                    case 3: return "Вторник";
                    case 4: return "Среда";
                    case 5: return "Четверг";
                    case 6: return "Пятница";
                    case 0: return "Суббота";
                    default: throw new ArgumentException("Неправильно введен месяц");
                }
            }
        }
    }
}