using Tyuiu.KalininaMA.Sprint3.Task7.V25.Lib;
namespace Tyuiu.KalininaMA.Sprint3.Task7.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Калинина Мария Александровна | РППб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Оператор цикла for                                                      *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнила: Калинина Мария Александровна | РППб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");

            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
            Console.WriteLine("* F(x) = (cos(x) + 4x) / (2 - sin(x) * 3x)                                *");
            Console.WriteLine("* на диапазоне [-5; 5] с шагом 1. Проверить деление на ноль.              *");
            Console.WriteLine("* Значения округлить до двух знаков после запятой.                        *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага - " + startValue);
            Console.WriteLine("Конец шага - " + stopValue);
            int len = ds.GetMassFunction(startValue, stopValue).Length;
            double[] res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine();

            Console.WriteLine("|    X     |   f(x)    |");

            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}     |  {1,6:f2}   |", startValue, res[i]);
                startValue++;
            }

            Console.ReadKey();
        }
    }
}