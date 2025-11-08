using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VdovinA.Sprint1.Task2.V24.Lib;

namespace Tyuiu.VdovinA.Sprint1.Task2.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int num1, num2;

            Console.WriteLine("Введите первое число:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Используем метод, требуемый интерфейсом
            int result = ds.CalculateDiffSquare(num1, num2);

            Console.WriteLine($"Разница чисел: {num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"Квадрат разницы: ({num1} - {num2})^2 = {result}");

            Console.ReadLine();
        }
    }
}