using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GaninAS.Sprint3.Task6.V16.Lib
{
    public class DataService : ISprint3Task6V16
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            {
                int sum = 0;
                for (int i = startValue; i <= stopValue; i++)
                {
                    for (int d = 1; d < 16; d++)
                    {
                        if (i % d == 0)
                        {
                            sum += d;
                        }
                    }
                }
                return sum;
            }
        }
    }
}

