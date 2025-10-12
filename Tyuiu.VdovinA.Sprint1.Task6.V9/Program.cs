using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VdovinA.Sprint1.Task6.V9.Lib;

//ЗАДАНИЕ
//Написать программу: пользователь вводит текст.
//Напечатать все слова, перенеся их последнюю букву в начало.

namespace Tyuiu.VdovinA.Sprint1.Task6.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите текст:");
            string str = Console.ReadLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string result = ds.MoveLastLetterToStart(str);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}