using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    static class PrimeNumberCheck
    {
        public static bool Check(params int[] numbers)
        {
            foreach (var item in numbers)
            {
                for (int i = 2; i < Math.Sqrt(item); i++)
                {
                    if (item % i == 0)
                        return false;
                }
            }
            return true;
        }
    }
}
