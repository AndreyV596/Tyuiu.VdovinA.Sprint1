using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VdovinA.Sprint1.Task0.V6.Lib;

namespace Tyuiu.VdovinA.Sprint1.Task0.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Вдовин Андрей | ПКТб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                             *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                         *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Вдовин Андрей | ПКТб-25-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 3*(4+1)             *");
            Console.WriteLine("* и печатает результат на экране.                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* 3*(4+1)                                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine(ds.Calculate());

            Console.ReadLine();

        }
    }
}