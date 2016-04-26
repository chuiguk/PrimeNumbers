using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Простые числа: "); 
            for (int i = 1; i <= 1000000; i++ )
            {
                if (PrimeNumberCheck.Check(i, Shift.LeftShift(i), Shift.RightShift(i)))
                    Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
