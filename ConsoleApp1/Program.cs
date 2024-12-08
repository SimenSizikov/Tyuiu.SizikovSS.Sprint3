namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 6;
            int c = 7;
            int d = 8;
            int i = 1;
            while (i<4)
            { 
                b--;
                b += a;
                c = b - a;
                d = (c + a) - i;
                i++;
            }
        Console.WriteLine(d);
        }
    }
}
