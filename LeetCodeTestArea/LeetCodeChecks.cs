using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static bool PalendromeCheck (int x)
        {
            if (x < 0)
            {
                return false;
            }

            List<int> listOfSeperatedNumbers = new List<int> ();
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
                    if (x - currentMultiplier*10 < 0)
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
    }
}
