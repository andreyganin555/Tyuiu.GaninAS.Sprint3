using Tyuiu.GaninAS.Sprint3.Task3.V11.Lib;
namespace Tyuiu.GaninAS.Sprint3.Task3.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Ганин Андрей Сергеевич | ПКТБ-25-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Оператор цикла foreach                                                  *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Ганин Андрей Сергеевич | ПКТБ-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");

            Console.WriteLine("*Используя цикл foreach заменить буквы q на цифру 7 в строке: sqwreq vqwqq q*");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "sqwreq vqwqq q";
            char replaceable = 'q';
            char replacement = '7';

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.ReplaceCharOnNum(value, replaceable, replacement);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}