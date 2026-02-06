using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GaninAS.Sprint3.Task6.V16.Lib

{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 5;
            int stopValue = 16;

            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 189;

            Assert.AreEqual(wait, res);
        }
    }
}