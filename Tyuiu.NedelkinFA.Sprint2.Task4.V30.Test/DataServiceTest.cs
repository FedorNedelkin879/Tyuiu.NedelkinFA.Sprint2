using Tyuiu.NedelkinFA.Sprint2.Task4.V30.Lib;

namespace Tyuiu.NedelkinFA.Sprint2.Task4.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 3.5;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 15;
            double res = ds.Calculate(x, y);
            double wait = 1.167;
            Assert.AreEqual(wait, res);
        }
    }
}