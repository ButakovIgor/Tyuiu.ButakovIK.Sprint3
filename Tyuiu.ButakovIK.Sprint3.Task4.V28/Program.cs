using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ButakovIK.Sprint3.Task4.V28.Lib;

//На отрезке, где x принимает значения от -5 до 5, вычислить значение функции y=(cos(x)+sin(x))/x
//При х = 0 пропустить значение. Полученные значения суммировать.

namespace Tyuiu.ButakovIK.Sprint3.Task4.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Бутаков И.К. | АСОиУБ-23-1";

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* Спринт #3                                                                      *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                       *");
            Console.WriteLine("* Таск #4                                                                        *");
            Console.WriteLine("* Вариaнт #28                                                                    *");
            Console.WriteLine("* Выполнил: Бутаков Игорь Константинович | АСОиУБ-23-1                           *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                       *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение функции    *");
            Console.WriteLine("* y=(cos(x)+sin(x))/x. При х = 0 пропустить значение.                            *");
            Console.WriteLine("* Полученные значения суммировать.                                               *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");
            int start = -5;
            int end = 5;

            Console.WriteLine("Начало цикла: " + start);
            Console.WriteLine("Конец цикла: " + end);


            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                      *");
            Console.WriteLine("**********************************************************************************");

            Console.WriteLine("Сумма без 0: " + ds.Calculate(start, end));

            Console.ReadKey();
        }
    }
}
