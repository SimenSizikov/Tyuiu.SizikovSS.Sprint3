using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SizikovSS.Sprint3.Task4.V27.Lib
{
    public class DataService : ISprint3Task4V27
    {
        public double Calculate(int startValue, int stopValue)
        {
            double y = 0;
            double res = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0) break;
                else y = x / (Math.Cos(x) + Math.Sin(x));
                res += y;
            }
            return Math.Round(y);
        }
    }
}
