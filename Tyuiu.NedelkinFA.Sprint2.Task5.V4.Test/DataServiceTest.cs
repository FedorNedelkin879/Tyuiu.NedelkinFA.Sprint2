using Tyuiu.NedelkinFA.Sprint2.Task5.V4.Lib;

namespace Tyuiu.NedelkinFA.Sprint2.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthName()
        {
            DataService ds = new DataService();
            Assert.AreEqual("���", ds.FindCardSuit(1));
            Assert.AreEqual("���", ds.FindCardSuit(2));
            Assert.AreEqual("���", ds.FindCardSuit(3));
            Assert.AreEqual("���", ds.FindCardSuit(4));
            Assert.AreEqual("���", ds.FindCardSuit(5));
            Assert.AreEqual("���", ds.FindCardSuit(6));
            Assert.AreEqual("���", ds.FindCardSuit(7));
            Assert.AreEqual("���", ds.FindCardSuit(8));
            Assert.AreEqual("���", ds.FindCardSuit(9));
            Assert.AreEqual("���", ds.FindCardSuit(10));
            Assert.AreEqual("���", ds.FindCardSuit(11));
            Assert.AreEqual("���", ds.FindCardSuit(12));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardSuit(-1);
            });

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardSuit(13);
            });
        }
    }
}