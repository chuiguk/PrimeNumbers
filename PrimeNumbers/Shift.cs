using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    static class Shift
    {
        public static int LeftShift(int number)
        {
            string strNumber = number.ToString();
            char[] charNumber = strNumber.ToCharArray();
            char[] tempChar = new char[charNumber.Length];
            tempChar[charNumber.Length - 1] = charNumber[0];
            for (int i = 0; i < charNumber.Length - 1; i++)
            {
                tempChar[i] = charNumber[i + 1];                
            }
            string @string = new string(tempChar);            
            return Convert.ToInt32(@string);
        }
        public static int RightShift(int number)
        {
            string strNumber = number.ToString();
            char[] charNumber = strNumber.ToCharArray();
            char[] tempChar = new char[charNumber.Length];
            tempChar[0] = charNumber[charNumber.Length - 1];
            for (int i = 0; i < charNumber.Length - 1; i++)
            {
                tempChar[i+1] = charNumber[i];
            }
            string @string = new string(tempChar); 
            return Convert.ToInt32(@string);
        }
    }
}
