namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            double sp = 1;
            int i = 0;
            for (x = -2; x <= 2; x++)
            {
                if (x == 0)
                {   
                    break;
                }
                sp = sp * (3*x+1);
                i++;
            }
            Console.WriteLine(sp);
        }
    }
}
