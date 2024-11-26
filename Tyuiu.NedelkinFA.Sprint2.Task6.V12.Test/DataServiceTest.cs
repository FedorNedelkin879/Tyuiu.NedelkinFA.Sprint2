using Tyuiu.NedelkinFA.Sprint2.Task6.V12.Lib;

namespace Tyuiu.NedelkinFA.Sprint2.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();

            Assert.AreEqual("31 ��� 2023", ds.FindDateOfPreviousDay(2024, 1, 1));
            Assert.AreEqual("31 ��� 2024", ds.FindDateOfPreviousDay(2024, 2, 1));
            Assert.AreEqual("31 ��� 2024", ds.FindDateOfPreviousDay(2024, 4, 1));
            Assert.AreEqual("30 ��� 2024", ds.FindDateOfPreviousDay(2024, 5, 1));
            Assert.AreEqual("31 ��� 2024", ds.FindDateOfPreviousDay(2024, 6, 1));
            Assert.AreEqual("30 ��� 2024", ds.FindDateOfPreviousDay(2024, 7, 1));
            Assert.AreEqual("31 ��� 2024", ds.FindDateOfPreviousDay(2024, 8, 1));
            Assert.AreEqual("31 ��� 2024", ds.FindDateOfPreviousDay(2024, 9, 1));
            Assert.AreEqual("30 ��� 2024", ds.FindDateOfPreviousDay(2024, 10, 1));
            Assert.AreEqual("31 ��� 2024", ds.FindDateOfPreviousDay(2024, 11, 1));
            Assert.AreEqual("30 ��� 2024", ds.FindDateOfPreviousDay(2024, 12, 1));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfPreviousDay(2024, -1, 1);
            });

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfPreviousDay(2024, 13, 1);
            });

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfPreviousDay(2024, 2, 30);
            });
        }
    }
}
