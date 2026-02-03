using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GaninAS.Sprint3.Task2.V7.Lib
{
    public class DataService : ISprint3Task2V7
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sum = 0;
            int k = 1;

            do
            {
                double term = 1.0 / Math.Sin(k);
                term = term * term; // (1/sin(k))^2
                sum += term;
                k++;
            } while (k <= 10);
            return Math.Round(sum, 3);
        }
       
}   }
            
    
        