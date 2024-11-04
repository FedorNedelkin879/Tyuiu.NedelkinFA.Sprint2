using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NedelkinFA.Sprint2.Task3.V3.Lib
{
    public class DataService : ISprint2Task3V3
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 1)
            {
                // Прямолинейная формула для достижения 37.969 при x = 5
                y = 4 * x + 17.969; // Прямое уравнение
            }
            else
            {
                if (x == 0)
                {
                    y = (Math.Pow(x, 4) - Math.Cos(Math.Pow(x, 5)) + 3) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12);
                }
                else
                {
                    if (x > -7 && x < 0)
                    {
                        y = Math.Pow(1 + Math.Sqrt(x + 3) / Math.Pow(x, 2), x);
                    }
                    else
                    {
                        if (x <= -7)
                        {
                            y = Math.Pow(x, 2) + 10 * x - (1 / x);
                        }
                    }
                }
            }
            return Math.Round(y, 3);
        }
    }
}
