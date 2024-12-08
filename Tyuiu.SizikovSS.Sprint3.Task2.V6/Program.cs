using Tyuiu.SizikovSS.Sprint3.Task2.V6.Lib;

namespace Tyuiu.SizikovSS.Sprint3.Task2.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new();

            Console.Title = "Спринт #3 | Выполнил: Сизиков С. С. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Новиков Д. С. | РППб-24-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет                *");
            Console.WriteLine("* произведение ряда по формуле.                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x, y;
            double a;

            do
            {
                Console.WriteLine("Введите значение a:");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите начальное значение:");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите конечное значение:");
                y = Convert.ToInt32(Console.ReadLine());

                if (x > y) Console.WriteLine("Начальное значение не может быть больше конечного, попробуйте ещё раз.");
            } while (x > y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.GetMultiplySeries(a, x, y));
            Console.ReadKey();
        }
    }
}
