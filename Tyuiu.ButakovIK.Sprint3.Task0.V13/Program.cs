using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ButakovIK.Sprint3.Task0.V13.Lib;

namespace Tyuiu.ButakovIK.Sprint3.Task0.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Бутаков И.К. | АСОиУБ-23-1";

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #3                                                                  *");
            Console.WriteLine("* Тема: Оператор цикла for                                                   *");
            Console.WriteLine("* Таск #0                                                                    *");
            Console.WriteLine("* Вариант #13                                                                *");
            Console.WriteLine("* Выполнил: Бутаков Игорь Константинович | АСОиУБ-23-1                       *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет сумму ряда по     *");
            Console.WriteLine("* формуле, при a = 0,5                                                       *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            double value = 0.5;
            int startValue = 1;
            int stopValue = 20;

            Console.WriteLine("Переменная X = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(value, startValue, stopValue));

            Console.ReadKey();
        }
    }
}
