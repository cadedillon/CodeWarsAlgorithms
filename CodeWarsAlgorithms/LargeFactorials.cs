using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsAlgorithms
{
    public class LargeFactorials
    {
        public static string Factorial(int n)
        {
            //Declare an array of max possible size so that we can hold as many digits of our factorial as needed
            int[] result = new int[500];
            //Because 0! = 1, we initialize result[0] to 1
            result[0] = 1;
            int resultSize = 1;
            string display = "";
            //Iterate through the array, initializing the resultSize variable with the result of the Multiply method
            for (int x = 2; x <= n; x++)
            {
                resultSize = Multiply(x, result, resultSize);
            }
            //Take the result of the previous for loop and iterate through it backwards,
            //Concatenating the digits of the factorial to a display string
            for (int i = resultSize - 1; i >= 0; i--)
            {
                display += result[i];
            }

            return display;
        }
        //The multiply method does the heavy lifting of the application. 
        //Through a series of arithmetic operations, we write the digits of
        //the factorial to the result array. The resultSize variable is equal to how 
        //many digits long the result will be.
        public static int Multiply(int x, int[] result, int resultSize)
        {
            int carry = 0;
            for (int i = 0; i < resultSize; i++)
            {
                int prod = result[i] * x + carry;
                result[i] = prod % 10;
                carry = prod / 10;
            }

            while (carry != 0)
            {
                result[resultSize] = carry % 10;
                carry = carry / 10;
                resultSize++;
            }
            return resultSize;
        }
    }
}
