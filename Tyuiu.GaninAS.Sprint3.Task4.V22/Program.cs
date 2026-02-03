using Tyuiu.GaninAS.Sprint3.Task4.V22.Lib;
namespace Tyuiu.GaninAS.Sprint3.Task4.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Ганин Андрей Сергеевич | ПКТБ-25-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Использование операторов continue и break в циклах                      *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #22                                                            *");
            Console.WriteLine("* Выполнил: Ганин Андрей Сергеевич | ПКТБ-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");

            Console.WriteLine("*На отрезке, где x принимает значения от -5 до 5, вычислить значение функц*");
            Console.WriteLine("*ции y=sin(x)/x. При х = 0 прервать цикл. Полученные значения перемножать.*");
            Console.WriteLine("*.                                                                        *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            Console.WriteLine("Множитель ряда = " + ds.Calculate(startValue, stopValue));
            Console.ReadKey();
        }
    }
}