using Tyuiu.SizikovSS.Sprint3.Task5.V19.Lib;

namespace Tyuiu.SizikovSS.Sprint3.Task5.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new();

            Console.Title = "Спринт #3 | Выполнил: Сизиков С. С. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Сизиков С. С. | РППб-24-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Решить уравнение, изображенное на картинке, при X = 5.                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x, a1, a2, b1, b2;

            do
            {
                Console.WriteLine("Введите начальное значение a1:");
                a1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите конечное значение a2:");
                a2 = Convert.ToInt32(Console.ReadLine());

                if (a1 > a2) Console.WriteLine("Начальное значение не может быть больше конечного, попробуйте ещё раз.");
            } while (a1 > a2);

            do
            {
                Console.WriteLine("Введите начальное значение b1:");
                b1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите конечное значение b2:");
                b2 = Convert.ToInt32(Console.ReadLine());

                if (b1 > b2) Console.WriteLine("Начальное значение не может быть больше конечного, попробуйте ещё раз.");
            } while (b1 > b2);

            Console.WriteLine("Введите значение X:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Результат произведения: " + ds.GetSumSumSeries(x, a1, a2, b1, b2));
            Console.ReadLine();
        }
    }
}
