using System;

namespace LeetCodeTestArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int numberLookingFor = 14;
            //var addedNumbers = LeetCodeChecks.TwoSum([1,2,5,7,9], numberLookingFor);
            //Console.WriteLine($"Index of First Number: {addedNumbers[0]} + Index of Second Number: {addedNumbers[1]}");

            //var IsPalindrome = LeetCodeChecks.PalendromeCheck(1000000001);
            //Console.WriteLine(IsPalindrome);

            //int convertedNumber = LeetCodeChecks.RomanToInt("MCMXCIV");
            //Console.WriteLine($"The value of the Roman Numeral is - {convertedNumber}");

            string[] strs = ["ab", "a"];
            string commonPrefix = LeetCodeChecks.LongestCommonPrefix(strs);
            Console.WriteLine(commonPrefix);
        }
    }
}