using Tyuiu.GaninAS.Sprint3.Task2.V7.Lib;

namespace Tyuiu.GaninAS.Sprint3.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumSeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetSumSeries(startValue, stopValue);

            double wait = 81.083;

            Assert.AreEqual(wait, res);
        }
    }
}