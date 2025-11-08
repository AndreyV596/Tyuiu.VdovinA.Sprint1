using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VdovinA.Sprint1.Task3.V3.Lib
{
    public class DataService : ISprint1Task3V0
    {
        public double Calculate(double a, double b, double c)
        {
            return a * b * c;
        }

        double ISprint1Task3V0.Calculate(double a, double b)
        {
            throw new NotImplementedException();
        }
    }
}