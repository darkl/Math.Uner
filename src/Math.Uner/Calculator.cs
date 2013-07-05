using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.Uner
{
    public class Calculator<T> : ICalculator<T>
    {
        public T Add(T x, T y)
        {
            dynamic dynamixX = x;
            dynamic dynamixY = y;

            T result = (T) (dynamixX + dynamixY);
            return result;
        }
    }
}
