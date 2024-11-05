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
            Assert.AreEqual("янв", ds.FindCardSuit(1));
            Assert.AreEqual("фев", ds.FindCardSuit(2));
            Assert.AreEqual("мар", ds.FindCardSuit(3));
            Assert.AreEqual("апр", ds.FindCardSuit(4));
            Assert.AreEqual("май", ds.FindCardSuit(5));
            Assert.AreEqual("июн", ds.FindCardSuit(6));
            Assert.AreEqual("июл", ds.FindCardSuit(7));
            Assert.AreEqual("авг", ds.FindCardSuit(8));
            Assert.AreEqual("сен", ds.FindCardSuit(9));
            Assert.AreEqual("окт", ds.FindCardSuit(10));
            Assert.AreEqual("ноя", ds.FindCardSuit(11));
            Assert.AreEqual("дек", ds.FindCardSuit(12));

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