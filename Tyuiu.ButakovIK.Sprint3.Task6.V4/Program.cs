using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ButakovIK.Sprint3.Task6.V4.Lib;

namespace Tyuiu.ButakovIK.Sprint3.Task6.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Бутаков И.К. | АСОиУБ-23-1";

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* Спринт #3                                                                      *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                                       *");
            Console.WriteLine("* Таск #6                                                                        *");
            Console.WriteLine("* Вариaнт #4                                                                     *");
            Console.WriteLine("* Выполнил: Бутаков Игорь Константинович | АСОиУБ-23-1                           *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                       *");
            Console.WriteLine("* Написать программу, которая ищет среди целых чисел, принадлежащих числовому    *");
            Console.WriteLine("* отрезку [14, 20] кол-во всех делителей больше 9.                               *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");

            int startValue = 14;
            int stopValue = 20;

            Console.WriteLine("Начало: " + startValue);
            Console.WriteLine("Конец: " + stopValue);


            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                     *");
            Console.WriteLine("**********************************************************************************");

            Console.WriteLine("Количество делителей = " + ds.GetSumTheDivisors(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
