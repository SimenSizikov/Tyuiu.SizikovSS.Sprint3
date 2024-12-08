using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SizikovSS.Sprint3.Task1.V27.Lib
{
    public class DataService : ISprint3Task1V27
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double p = 1;
            for (int k = startValue; k <= stopValue; k++)
            {
                p *= Math.Pow(( 1/Math.Pow(value,k) ),3);
            }
            return Math.Round(p, 3);
        }
    }
}
