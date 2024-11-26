using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NedelkinFA.Sprint2.Task6.V12.Lib
{
    public class DataService : ISprint2Task6V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            if (m < 1 || m > 12)
                throw new ArgumentException($"Неверный месяц: {m}");
            if (n < 1 || n > 31)
                throw new ArgumentException($"Неверный день: {n}");

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
                    _ => throw new ArgumentException($"Некорректный месяц: {m}")
                };
            }
            else
            {
                n--;
            }

            return $"{n:00}.{m:00}.{g}";
        }
    }
}
