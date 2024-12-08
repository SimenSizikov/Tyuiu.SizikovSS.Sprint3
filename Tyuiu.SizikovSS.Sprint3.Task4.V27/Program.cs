using Tyuiu.SizikovSS.Sprint3.Task4.V27.Lib;

namespace Tyuiu.SizikovSS.Sprint3.Task4.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new();

            Console.Title = "Спринт #3 | Выполнил: Сизиков С. С. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Сизиков С. С. | РППб-24-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение     *");
            Console.WriteLine("* функции y=x/(cos(x)+sin(x))                                             *");
            Console.WriteLine("* При х = 0 пропустить значение. Полученные значения суммировать.         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int a, b;

            do
            {
                Console.WriteLine("Введите начальное значение x:");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите конечное значение x:");
                b = Convert.ToInt32(Console.ReadLine());

                if (a > b) Console.WriteLine("Начальное значение не может быть больше конечного, попробуйте ещё раз.");
            } while (a > b);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(a,b));
            Console.ReadKey();
        }
    }
}
