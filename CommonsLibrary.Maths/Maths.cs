using System;

namespace CommonsLibrary.Maths
{
    /// <summary>The genera maths library</summary>
    public static class Maths
    {
        /// <summary>Checks if the number is prime or not.</summary>
        /// <param name="number">Any positive integer with a value greater than 0</param>
        /// <returns>A boolean based on if the number is prime or not.</returns>
        /// <exception cref="System.ArgumentException">A non-integer based value has been entered.</exception>
        /// <exception cref="System.ArgumentNullException">
        /// <paramref name="number" /> is <see langword="null" />.</exception>
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
    }
}