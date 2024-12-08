using System.Diagnostics.Metrics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumd = 0;
            int x;
            for (x = 5; x <= 10; x++)
            {
                for (int d = 1; d <= x; d++)
                {
                    if (x % d == 0)
                    {
                        if (d > 5)
                        {
                            sumd = sumd + d;
                        }
                    }      
                }
            }
            Console.WriteLine(sumd);
        }
    }
}
