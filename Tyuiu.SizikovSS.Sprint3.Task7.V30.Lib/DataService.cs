using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SizikovSS.Sprint3.Task7.V30.Lib
{
    public class DataService : ISprint3Task7V30
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int count = 0;
            for (int x = startValue; x <= stopValue; x++) count++;

            double[] mass = new double[count];
            int k = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Sin(x) + 2 == 0)
                {
                    mass[k] = 0;
                    continue;
                }
                mass[k] = Math.Round(( (5*x+2.5)/(Math.Sin(x) + 2) + 2*x + 2 ),3);
            }
            return mass;
        }
    }
}
