using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GaninAS.Sprint3.Task1.V28.Lib
{
    public class DataService : ISprint3Task1V28
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double SumSeries = 1;
            

            while (startValue <= stopValue)
            {
                double term = (Math.Pow(value, 1) + 0.25) * Math.Cos(1);
                startValue++;
            }
            return Math.Round(SumSeries, 3);
        }
    }
}