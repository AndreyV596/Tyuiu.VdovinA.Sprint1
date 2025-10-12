using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;


namespace Tyuiu.VdovinA.Sprint1.Task4.V9.Lib
{
    public class DataService
    {
        public double Calculate(double x, double y)
        {
            double numerator = Math.Log(x * y);
            double denominator = x - Math.Sqrt(1 + y * y);
            double result = numerator / denominator;
            return Math.Round(result, 3);
        }
    }
}