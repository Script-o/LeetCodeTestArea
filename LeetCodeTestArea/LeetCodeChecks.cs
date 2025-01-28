using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LeetCodeTestArea
{
    public static class LeetCodeChecks
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int numIndex = 0;
            int num2Index = 0;
            foreach (int num in nums)
            {
                num2Index = 0;
                foreach (int num2 in nums)
                {
                    int solution = num + num2;
                    if (numIndex == num2Index)
                    {
                        break;
                    }
                    if (target == solution)
                    {
                        return [numIndex, num2Index];
                    }
                    num2Index++;
                }
                numIndex++;
            }
            return [99, 99];
        }
        public static bool PalendromeCheck(int x)
        {
            if (x < 0)
            {
                return false;
            }

            List<int> listOfSeperatedNumbers = new List<int>();
            long currentMultiplier = 10;
            bool lastDigit = false;
            if (x < currentMultiplier)
            {
                lastDigit = true;
            }

            for (int i = 0; i < 10; i++)
            {
                long remainderOfx = x % currentMultiplier;
                Console.WriteLine($"{currentMultiplier / 10} Digit: x is currently {x}, the remainderOfx is currently {remainderOfx}");
                if (remainderOfx == 0)
                {
                    Console.WriteLine($"Adding {i} to list");
                    listOfSeperatedNumbers.Add(i);
                    if (lastDigit == true)
                    {
                        break;
                    }
                    if (x - currentMultiplier * 10 < 0)
                    {
                        lastDigit = true;
                    }
                    i = -1;
                    currentMultiplier *= 10;
                }
                else
                {
                    x -= (int)(currentMultiplier / 10);
                }
            }

            bool isPalendrome = true;
            int loopCount = 0;
            foreach (int currentListItem in listOfSeperatedNumbers)
            {
                loopCount++;
                int finalListPosition = listOfSeperatedNumbers.Count() - 1;
                int reflectedListItem = listOfSeperatedNumbers[finalListPosition - loopCount + 1];

                if (currentListItem != reflectedListItem)
                {
                    Console.WriteLine($"{currentListItem} != {reflectedListItem}");
                    isPalendrome = false;
                }
            }

            return isPalendrome;
        }

        public static int RomanToInt(string s)
        {
            char[] characters = s.ToCharArray();
            var romanNumerals = new List<(char, int)> { ('I', 1), ('V', 5), ('X', 10), ('L', 50), ('C', 100), ('D', 500), ('M', 1000) };
            int convertedNumber = 0;
            int previousNumber = 999999999;

            foreach (char character in characters)
            {
                //Console.WriteLine(character);
                foreach ((char, int) numeral in romanNumerals)
                {
                    //Console.WriteLine(numeral.Item1);
                    if (character == numeral.Item1)
                    {
                        if (previousNumber < numeral.Item2)
                        {
                            Console.WriteLine($"previous - {numeral.Item2}");
                            convertedNumber += -previousNumber * 2 + numeral.Item2;
                            previousNumber = numeral.Item2;
                            Console.WriteLine($"match - {convertedNumber}");
                            break;
                        }
                        convertedNumber += numeral.Item2;
                        previousNumber = numeral.Item2;
                        Console.WriteLine(convertedNumber);
                        break;
                    }
                }
                //Console.WriteLine(convertedNumber);
            }

            return convertedNumber;
        }

        //Take each word and break it down to individual charaters.
        //Compare the first letter to the first character of every other word.
        //If there is a match then do the same for the second character of any matches.
        //End if no matches.
        //Save the resulting matches in a collection to be compared for longest one.

        //From our input array select each individual string
        //On each string run through each individual character
        //Convert the array to a list
        //For each letter compare it to the current letter of each other string in the list
        //If the current number of matches is less than the current max matches then remove that string from the list

        public static string LongestCommonPrefix(string[] input)
        {
            int characterPosition = 0;
            string matchedCharacters = "";
            foreach (char currentLetter in input[0])
            {
                int numberOfMatches = 0;
                foreach (string comparedString in input)
                {
                    if (comparedString.Length < characterPosition + 1)
                    {
                        break;
                    }
                    if (currentLetter == comparedString[characterPosition])
                    {
                        numberOfMatches++;
                    }
                    
                    if (numberOfMatches == input.Length)
                    {
                        matchedCharacters += currentLetter;
                        characterPosition++;
                    }
                }
            }
            return matchedCharacters;
        }      
    }
}
