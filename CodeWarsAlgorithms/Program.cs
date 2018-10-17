using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsAlgorithms
{
    class Program
    {
        static readonly string format = "\n\t";
        static void Main(string[] args)
        {
            Console.WriteLine(format + "Welcome to my CodeWars repositories! " +
                "\n\tThis is just a sample of all of the problems I have solved. \n\tView my full profile at https://codewars.com/users/cade.dillontech");
            Console.WriteLine(format + "A note about solution naming: Codewars uses a 'Kata' system to categorize algorithms by difficulty." +
                format + "The lower the Kata, the more difficult the algorithm is to solve." +
                format + "The classes are fully commented, so please dig around!");
            Console.ReadLine();
            SelectAlgorithm();
        }

        public static void SelectAlgorithm()
        {
            try {
                Console.WriteLine(format + "Select a function from below to test it.");
                Console.WriteLine(format + "1. (Kata 4) LargeFactorials: Enter a number and function returns the factorial of the number.");
                Console.WriteLine(format + "2. (Kata 5) ConvertImproperFractions: Enter an improper fraction and the " +
                    format + "function returns the proper mixed number.");
                Console.WriteLine(format + "3. (Kata 5) GreedIsGood: Populate an array of six-sided dice and the function scores " +
                    format + "it according to the rules of 'Greed.'");
                Console.WriteLine(format + "4. (Kata 5) Rot13: Enter a string and the function will rotate each of the letters in the string 13 characters.");
                Console.WriteLine(format + "5. (Kata 5) WriteNumbers: Enter a number the function writes the number out in words.");
                Console.WriteLine(format + "6. (Kata 6) BreakCamelCase: Enter a string formatted in camelCase and the " +
                    format + "function will break it into individual words.");
                Console.WriteLine(format + "7. (Kata 6) ConvertStringToCamelCase: Enter a string of words seperated by hyphens and the function " +
                    format + "returns a camelCase string.");
                Console.WriteLine(format + "8. (Kata 6) FindOddInteger: Populate an array with integers, but only one " +
                   format + "integer may appear an odd number of times. The function finds that number.");
                Console.WriteLine(format + "9. (Kata 6) MorseCodeTranslator: Enter a string of morse code and function decodes it.");
                Console.WriteLine(format + "10. Exit the program.");

                int userSelect = int.Parse(Console.ReadLine());
                if (userSelect < 1 || userSelect > 10)
                {
                    throw new ArgumentException();
                }
                int intPut;
                string stringInput;
                switch (userSelect)
                {
                    case 1:
                        Console.WriteLine(format + "Enter a number and my function will return its factorial. (Upper limit is 253)");
                        intPut = int.Parse(Console.ReadLine());
                        Console.WriteLine(format + $"The factorial is: {LargeFactorials.Factorial(intPut)}");
                        Console.ReadLine();
                        SelectAlgorithm();
                        break;
                    case 2:
                        Console.WriteLine(format + "Enter a positive improper fraction in the format of '42/9' and the function will return a mixed number.");
                        stringInput = Console.ReadLine();
                        Console.WriteLine(format + $"The mixed number is: {ConvertImproperFractions.MixedNumberFx(stringInput)}");
                        Console.ReadLine();
                        SelectAlgorithm();
                        break;
                    case 3:
                        try
                        {
                            Console.WriteLine(format + "Populate an array with five six-sided dice rolls. " +
                                format + "The function will score the array based on the rules of 'Greed,' outlined in the comments.");
                            int[] dice = new int[5];
                            for (int i = 0; i < dice.Length; i++)
                            {
                                Console.WriteLine(format + $"Populate the value of the die in position: {i + 1}");
                                intPut = int.Parse(Console.ReadLine());
                                if (intPut < 1 || intPut > 6)
                                {
                                    throw new ArgumentException();
                                }
                                dice[i] = intPut;
                            }
                            Console.WriteLine(format + $"The score of the dice rolls is: {GreedIsGood.CalculateScore(dice)}");
                            Console.ReadLine();
                            SelectAlgorithm();
                        }
                        catch (ArgumentException aEx)
                        {
                            Console.WriteLine(aEx.Message);
                        }
                        break;
                    case 4:
                        Console.WriteLine(format + "Enter a string and the function will rotate each letter 13 places.");
                        stringInput = Console.ReadLine();
                        Console.WriteLine(format + $"The rotated string is: {Rotate13.Rotate13Fx(stringInput)}");
                        Console.ReadLine();
                        SelectAlgorithm();
                        break;
                    case 5:
                        Console.WriteLine(format + "Enter a positive integer and my function will write it out in words.");
                        intPut = int.Parse(Console.ReadLine());
                        Console.WriteLine(format + $"The number you entered was: {NumberTranslator.Number2Words(intPut)}");
                        Console.ReadLine();
                        SelectAlgorithm();
                        break;
                    case 6:
                        Console.WriteLine(format + "Enter a camelCase string and my function will return a string with spacing inserted.");
                        stringInput = Console.ReadLine();
                        Console.WriteLine(BreakCamelCase.BreakCamelFx(stringInput));
                        Console.ReadLine();
                        SelectAlgorithm();
                        break;
                    case 7:
                        Console.WriteLine(format + "Enter a string with '-' or '_' between each word and my function will return a camelCase string.");
                        stringInput = Console.ReadLine();
                        Console.WriteLine(ConvertStringToCamelCase.ToCamelCaseFx(stringInput));
                        Console.ReadLine();
                        SelectAlgorithm();
                        break;
                    case 8:
                        Console.WriteLine(format + "Populate an array of 5 numbers, but only one integer can appear an odd number of times.");
                        int[] userArray = new int[5];
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine(format + $"Enter an integer for position {i + 1}.");
                            userArray[i] = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine(format + $"The integer that appears an odd number of times is: {FindOddInteger.FindItFx(userArray)}");
                        Console.ReadLine();
                        SelectAlgorithm();
                        break;
                    case 9:
                        Console.WriteLine(format + "Enter a string of morse code and my function will decode it.");
                        Console.WriteLine(format + "Morse code letters have one space between them, and words have three spaces between them.");
                        stringInput = Console.ReadLine();
                        Console.WriteLine(MorseDecoder.Decode(stringInput));
                        Console.ReadLine();
                        SelectAlgorithm();
                        break;
                    default:
                        break;
                }
            }
        
            catch (ArgumentException aEx)
            {
                Console.WriteLine(format + aEx.Message);
            }
            catch (FormatException fEx)
            {
                Console.WriteLine(format + fEx.Message);
            }
            finally
            {
                Console.WriteLine(format + "Thanks for checking out my algorithm solutions. I update this directory every couple of weeks, " +
                    format + "so check back soon!");
            }
        }

    }
}
    

