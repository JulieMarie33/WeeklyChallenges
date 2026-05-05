using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            bool hasNumber = false;
            double min = 0;
            double max = 0;

            foreach (double number in numbers)
            {
                if (!hasNumber)
                {
                    min = number;
                    max = number;
                    hasNumber = true;
                }
                else
                {
                    if (number < min)
                    {
                        min = number;
                    }

                    if (number > max)
                    {
                        max = number;
                    }
                }
            }

            if (!hasNumber)
            {
                return 0;
            }

            return min + max;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }

            return str2.Length;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            int total = 0;

            foreach (int number in numbers)
            {
                total += number;
            }

            return total;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            int total = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    total += number;
                }
            }

            return total;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                return false;
            }

            int total = 0;

            foreach (int number in numbers)
            {
                total += number;
            }

            return total % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
            {
                return 0;
            }

            return number / 2;
        }
    }
}