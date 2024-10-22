using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NedelkinFA.Sprint2.Task1.V8.Lib
{
    public class DataService : ISprint2Task1V8
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a > b) | (c < d);
            res[1] = (a > b + 1231231) & (c < d);
            res[2] = (a > b) || (c < d);
            res[3] = (a > b + 123123123) && (c < d);
            res[4] = !res[0];
            res[5] = (a + 123123123> b) ^ (c < d);
            return res;
        }
    }
}
