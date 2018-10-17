using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsAlgorithms
{
    public class GreedIsGood
    {
        // Greed is a dice game played with five six-sided dice. Score a throw according to these rules. 
        // You will always be given an array with five six-sided dice values.
        //      Three 1's => 1000 points
        //      Three 6's =>  600 points
        //      Three 5's =>  500 points
        //      Three 4's =>  400 points
        //      Three 3's =>  300 points
        //      Three 2's =>  200 points
        //      One   1   =>  100 points
        //      One   5   =>   50 point
        //A single die can only be counted once in each roll. 
        //For example, a "5" can only count as part of a triplet (contributing to the 500 points) or as a single 50 points, but not both in the same roll.

        public static int CalculateScore(int[] dice)
        {
            //Initialize a set of counts for each possible die result
            int oneCount = 0;
            int twoCount = 0;
            int threeCount = 0;
            int fourCount = 0;
            int fiveCount = 0;
            int sixCount = 0;

            //Iterate through the array of dice rolls, incrementing the counting variables based on logic statements
            for (int i = 0; i < dice.Length; i++)
            {
                if (dice[i] == 1)
                    oneCount++;
                else if (dice[i] == 2)
                    twoCount++;
                else if (dice[i] == 3)
                    threeCount++;
                else if (dice[i] == 4)
                    fourCount++;
                else if (dice[i] == 5)
                    fiveCount++;
                else if (dice[i] == 6)
                    sixCount++;
            }
            int score = 0;

            //Take the die counts and calculate the score according to the rules outlined in the 
            //function instructions
            if (oneCount < 3 && oneCount != 0)
                score += oneCount * 100;
            else if (oneCount >= 3)
                score += 1000 + ((oneCount - 3) * 100);

            if (fiveCount < 3 && fiveCount != 0)
                score += fiveCount * 50;
            else if (fiveCount >= 3)
                score += 500 + ((fiveCount - 3) * 50);

            if (twoCount >= 3)
                score += 200;

            if (threeCount >= 3)
                score += 300;

            if (fourCount >= 3)
                score += 400;

            if (fiveCount >= 3)
                score += 500;

            if (sixCount >= 3)
                score += 600;

            //Return the calculated score
            return score;
        }
        
    }
}
