using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VdovinA.Sprint1.Task2.V24.Lib
{
    public class DataService
    {
        public int SqrOfDifference(int a, int b)
        {
            int difference = a - b;
            return difference * difference;
          
        }

        public int SqrOfDifference(int x)
        {
            throw new NotImplementedException();
        }
    }
}
    
    