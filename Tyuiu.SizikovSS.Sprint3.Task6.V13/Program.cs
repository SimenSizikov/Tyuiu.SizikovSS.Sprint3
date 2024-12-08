using Tyuiu.SizikovSS.Sprint3.Task6.V13.Lib;

namespace Tyuiu.SizikovSS.Sprint3.Task6.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new();

            Console.Title = "Спринт #3 | Выполнил: Сизиков С. С. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Сизиков С. С. | РППб-24-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая ищет среди целых чисел, принадлежащих       *");
            Console.WriteLine("* числовому отрезку [7, 17] сумму всех делителей, больше 8                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int a1, a2;

            do
            {
                Console.WriteLine("Введите начальное значение:");
                a1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите конечное значение:");
                a2 = Convert.ToInt32(Console.ReadLine());

                if (a1 > a2) Console.WriteLine("Начальное значение не может быть больше конечного, попробуйте ещё раз.");
            } while (a1 > a2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма всех делителей чисел, пренадлежащих отрезку [" + a1 + ", " + a2 + "] и больших. чем 8: " + ds.GetSumTheDivisors(a1, a2));
            Console.ReadLine();
        }
    }
}
