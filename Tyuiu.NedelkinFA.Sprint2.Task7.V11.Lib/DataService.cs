using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NedelkinFA.Sprint2.Task7.V11.Lib
{
    public class DataService : ISprint2Task7V11
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            return (Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) && (y >= x);
        }
    }
}

