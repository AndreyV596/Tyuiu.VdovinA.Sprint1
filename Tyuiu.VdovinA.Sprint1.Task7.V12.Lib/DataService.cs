using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VdovinA.Sprint1.Task7.V12.Lib
{
    public class DataService : ISprint1Task7V12
    {
        public double Calculate(double x, double y)
        {
            double term1 = Math.Pow((x + 1) / (x - 1), x);
            double term2 = 18 * x * Math.Pow(y, 2);
            double result = term1 + term2;

            return Math.Round(result, 3);
        }
    }
}