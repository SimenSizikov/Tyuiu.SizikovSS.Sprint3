namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 4;
            int c = 3;
            int d = 5;
            
            for (int i = 1; i < 5; i++)
            {
                c++;
                c += b;
                a = b+c;
                d = (a-b) + i;
            }
                Console.WriteLine(d);
            }
    }
}
