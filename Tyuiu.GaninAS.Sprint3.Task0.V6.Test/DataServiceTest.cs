using Tyuiu.GaninAS.Sprint3.Task0.V6.Lib;

namespace Tyuiu.GaninAS.Sprint3.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMultiplySeriesTest()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 15;

            double res = ds.GetMultiplySeries(startValue, stopValue);
            double wait = 0.0005577987874650453;

            Assert.AreEqual(wait, res);
        }
    }
}
   
