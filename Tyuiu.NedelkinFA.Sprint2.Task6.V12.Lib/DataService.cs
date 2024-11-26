using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NedelkinFA.Sprint2.Task6.V12.Lib
{
    public class DataService : ISprint2Task6V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            if (m < 1 || m > 12 || n < 1 || n > 31)
                throw new ArgumentException("Некорректные значения даты.");

            if (n == 1)
            {
                m--;
                if (m == 0)
                {
                    m = 12;
                    g--;
                }

                n = m switch
                {
                    1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                    4 or 6 or 9 or 11 => 30,
                    2 => 29,
                    _ => throw new ArgumentException("Некорректный месяц.")
                };
            }
            else
            {
                n--;
            }

            string monthName = m switch
            {
                1 => "янв",
                2 => "фев",
                3 => "мар",
                4 => "апр",
                5 => "май",
                6 => "июн",
                7 => "июл",
                8 => "авг",
                9 => "сен",
                10 => "окт",
                11 => "ноя",
                12 => "дек",
                _ => throw new ArgumentException("Некорректный месяц.")
            };

            return $"{n} {monthName} {g}";
        }
    }
}
