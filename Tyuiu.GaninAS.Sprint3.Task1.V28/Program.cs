using Tyuiu.GaninAS.Sprint3.Task1.V28.Lib;
namespace Tyuiu.GaninAS.Sprint3.Task1.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Ганин Андрей Сергеевич | ПКТБ-25-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Оператор цикла while                                                    *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Ганин Андрей Сергеевич | ПКТБ-25-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");

            Console.WriteLine("*Написать программу используя цикл while, которая вычисляет произведение р*");
            Console.WriteLine("*ряда по формуле, при a=0,5                                               *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Переменная a = ");
            double value = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Старт шага = ");
            int startValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Конец шага = ");
            int stopValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.GetSumSeries(value, startValue, stopValue);
            Console.WriteLine("Сумма ряда = " + result);
            Console.ReadKey();
        }
    }
}