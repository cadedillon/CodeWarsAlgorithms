using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsAlgorithms
{
    public class FindOddInteger
    {
        public static int FindItFx(int[] sequence)
        {
            //Iterate through the sequence of numbers, taking a count of how many times each number appears in the array
            for (int i = 0; i < sequence.Length; i++)
            {
                int count = 0;
                for (int index = 0; index < sequence.Length; index++)
                {

                    if (sequence[i] == sequence[index])
                        count++;
                }
                //Check if the count of the number is odd, if it is, return the number.
                if (count % 2 != 0)
                {
                    return sequence[i];
                }
            }

            return 0;
        }
    }
}
