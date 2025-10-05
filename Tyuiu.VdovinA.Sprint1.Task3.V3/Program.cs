using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VdovinA.Sprint1.Task3.V3.Lib;



//ЗАДАНИЕ
//Написать программу, которая запрашивает у пользователя исходные данные,
//выполняет указанные расчёты и печатает результат на экране.
//Расчеты: Объявите необходимые переменные и напишите программу вычисления площади прямоугольника.

namespace Tyuiu.VdovinA.Sprint1.Task3.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double a = 9;
            double b = 7.5;
            double c = 5;
            Console.WriteLine("Сторона А параллелепипеда = " + a);
            Console.WriteLine("Сторона B параллелепипеда = " + b);
            Console.WriteLine("Сторона C параллелепипеда = " + c);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Площадь параллелепипеда = " + ds.Calculate(a, b, c));

            Console.ReadKey();

        }
    }
}
