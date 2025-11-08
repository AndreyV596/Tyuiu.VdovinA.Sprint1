using System;
using Tyuiu.VdovinA.Sprint1.Task7.V12.Lib;

namespace Tyuiu.VdovinA.Sprint1.Task7.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("        x + 1");
            Console.WriteLine("z = (--------)^x + 18*x*y^2");
            Console.WriteLine("        x - 1");
            Console.WriteLine();

            double x, y;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.Calculate(x, y);
            Console.WriteLine($"z = {result}");
            Console.ReadKey();
        }
    }
}