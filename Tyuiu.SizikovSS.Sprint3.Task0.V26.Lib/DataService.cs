using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SizikovSS.Sprint3.Task0.V26.Lib
{
    public class DataService : ISprint3Task0V26
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double p = 0;
            for (int k = startValue; k <= stopValue; k++)
            {
                p = (Math.Pow(2, k) / (k + 1))* Math.Cos(1.8);
            }
            return Math.Round(p, 3);
        }
    }
}
