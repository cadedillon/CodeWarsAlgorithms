using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsAlgorithms
{
    public class Rotate13
    {
        public static string Rotate13Fx(string message)
        {
            //My approach to this rotate 13 cipher was to very simply initialize two arrays that contain the entire upper and lower case alphabets
            //Also, they contain the first 13 letters twice, so that if Z needs to rotated, it can be done internally in the array simply
            char[] alphabetUp = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q',
                                    'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'A', 'B', 'C',
                                        'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M' };
            char[] alphabetDown = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q',
                                    'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'a', 'b', 'c',
                                        'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm' };

            char[] messageArr = message.ToCharArray();
            char[] result = new char[message.Length];
            int index;

            //In this loop, we iterate through the message, casted to a character array, and we check to see
            //If the current letter is contained in the uppercase alphabet array, or the lowercase alphabet array
            //If it is, we iterate through the array until we find a match, and then write the letter plus 13
            //To the result array.
            for (int i = 0; i < messageArr.Length; i++)
            {
                if (Array.IndexOf(alphabetUp, messageArr[i]) != -1)
                {
                    //This solution is inelegant at best, a while loop that breaks when the letter is match would
                    //be a slightly better solution
                    foreach (char letter in alphabetUp)
                    {
                        if (letter.Equals(messageArr[i]) == true)
                        {
                            index = Array.IndexOf(alphabetUp, messageArr[i]);

                            result[i] = alphabetUp[index + 13];
                        }


                    }
                }

                else if (Array.IndexOf(alphabetDown, messageArr[i]) != -1)
                {
                    foreach (char letter in alphabetDown)
                    {
                        if (letter.Equals(messageArr[i]) == true)
                        {
                            index = Array.IndexOf(alphabetDown, messageArr[i]);

                            result[i] = alphabetDown[index + 13];
                        }


                    }
                }
                //If neither array contains the letter, it is determined to be a special character, and is copied as is.
                else
                {
                    result[i] = messageArr[i];
                }
            }

            string resultStr = "";
            //Iterate through the result character array and concatenate each letter to a string and return it
            foreach (char character in result)
            {
                resultStr += character;
            }
            return resultStr;
        }
    }
}
