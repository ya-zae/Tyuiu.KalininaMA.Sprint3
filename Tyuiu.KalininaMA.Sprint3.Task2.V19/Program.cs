using Tyuiu.KalininaMA.Sprint3.Task2.V19.Lib;
namespace Tyuiu.KalininaMA.Sprint3.Task2.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнила: Калинина Мария Александровна | РППб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Оператор цикла for                                                      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнила: Калинина Мария Александровна | РППб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");

            Console.WriteLine("*Написать программу используя цикл do...while, которая вычисляет сумму    *");
            Console.WriteLine("*ряда по формуле                                                          *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            Console.WriteLine("Введите начальное значение: ");
            int startValue = Convert.ToInt32(Console.ReadLine());
            int stopValue = 10;
            Console.WriteLine("Конечное значение = " + stopValue);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            var result = ds.GetSumSeries(startValue, stopValue);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}