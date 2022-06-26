using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionFunctions
{
    public class SimpleFunctions
    {
        public int SumOfFirstNNumbers(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            
            return (n + SumOfFirstNNumbers(n - 1));
        }

        public int Factorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            
            return (n * Factorial(n - 1));
        }
    }
}
