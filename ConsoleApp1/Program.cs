namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 4;
            int c = 8;
            int d = 7;
            int i = 1;
            do
            {
                b++;
                a -= b;
                c += a;
                d = (c - a) + i;
                i++;
            } while (i < 4);
        Console.WriteLine(d);
        }
    }
}
