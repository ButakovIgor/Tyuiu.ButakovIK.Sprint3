using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ButakovIK.Sprint3.Task3.V29.Lib;

namespace Tyuiu.ButakovIK.Sprint3.Task3.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Бутаков И.К. | АСОиУБ-23-1";

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* Спринт #3                                                                      *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                                   *");
            Console.WriteLine("* Таск #3                                                                        *");
            Console.WriteLine("* Вариaнт #29                                                                    *");
            Console.WriteLine("* Выполнил: Бутаков Игорь Константинович | АСОиУБ-23-1                           *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                       *");
            Console.WriteLine("* Используя цикл foreach удалить из строки все буквы h в строке: chgr vhhtg hnht *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");

            string value = "chgr vhhtg hhht";
            char chr = 'h';
            string res = ds.DeleteCharInString(value, chr);

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                     *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("Полученный текст: " + ds.DeleteCharInString(value,chr));

            Console.ReadKey();
        }
    }
}
