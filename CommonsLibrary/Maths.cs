using System;
using System.Collections.Generic;

namespace CommonsLibrary
{
    public static class Maths
    {
        /// <summary>
        /// This method checks if the number is prime or not
        /// </summary>
        /// <param name="number">Any positive integer with a value greater than 0</param>
        /// <returns>A boolean based on if the number is prime or not</returns>
        public static bool IsPrime(int number)
        {
            switch (number)
            {
                case <= 1:
                    return false;
                case 2 or 3 or 5:
                    return true;
            }

            if (number % 2 == 0 || number % 3 == 0 || number % 5 == 0) return false;

            int boundary = (int)Math.Floor(Math.Sqrt(number));

            int i = 6;
            while (i <= boundary)
            {
                if (number % (i + 1) == 0 || number % (i + 5) == 0) return false;
                i += 6;
            }

            return true;
        }

        /// <summary>
        /// This method returns all of the divisors of a number
        /// </summary>
        /// <param name="number">The number that you want to check</param>
        /// <returns>Every divisor of the number</returns>
        public static IEnumerable<int> GetDivisors(int number)
        {
            for (int i = 1; i * i <= number; i++)
            {
                if (number % i != 0) continue;
                yield return i;
                int y = number / i;
                if (i != y)
                    yield return y;
            }
        }

        /// <summary>
        /// This method returns all of the prime factors of a given number
        /// </summary>
        /// <param name="number">This is the signed integer that you want the prime factors of</param>
        /// <returns>An array of the prime factors</returns>
        public static int[] GetPrimeFactors(int number)
        {
            List<int> factors = new();
            if (number < 0) number *= -1;

            while (number % 2 == 0)
            {
                factors.Add(2);
                number /= 2;
            }

            for (int i = 3; i <= Math.Sqrt(number); i+= 2)
            {
                while (number % i == 0)
                {
                    factors.Add(i);
                    number /= i;
                }
            }

            if (number > 2) factors.Add(number);

            return factors.ToArray();
        }
    }
}