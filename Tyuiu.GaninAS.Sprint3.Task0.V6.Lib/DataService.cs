using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GaninAS.Sprint3.Task0.V6.Lib
{
    public class DataService : ISprint3Task0V6
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double p = 1.0;
            double term = 1.0 / Math.Pow(Math.Cos(5) + 1, 2);

            for (int k = 1; k <= 15; k++)
            {
                p *= term;
            }
            return p;
        }   
    }
}
   