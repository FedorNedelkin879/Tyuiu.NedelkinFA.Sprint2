using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NedelkinFA.Sprint2.Task4.V30.Lib
{
    public class DataService : ISprint2Task4V30
    {
        public double Calculate(double x, double y)
        {
            double z = x > y ? (y / x + 3) : ((y - 1) / x + 2);
            return Math.Round(z, 3);
        }
    }
}
