using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VdovinA.Sprint1.Task5.V3.Lib;

//ЗАДАНИЕ
//Присвоить целой переменной h третью от конца цифру в записи положительного целого числа k

namespace Tyuiu.VdovinA.Sprint1.Task5.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите положительное целое число k:");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(k);
            Console.WriteLine("Третья от конца цифра: " + res);

            Console.ReadKey();

        }
    }
}