using System.Collections.Generic;

namespace CommonsLibrary.Maths
{
    /// <summary>A class containing methods regarding sequences.</summary>
    public static class Sequences
    {
        /// <summary>It calculates the Nth value in the Fibonacci sequence.</summary>
        /// <param name="index">The index of the value you want to return.</param>
        /// <returns>An integer that's the Nth Fibonacci value.</returns>
        public static int NthFibonacciValue(int index)
        {
            if (index == 0) return 0;
            int prev = 0, next = 1;

            for (int i = 1; i < index; i++)
            {
                int sum = prev + next;
                prev = next;
                next = sum;
            }
            return next;
        }

        /// <summary>Calculates an array of Fibonacci values between two parameters.</summary>
        /// <param name="sequenceLength">The number of values you want to return.</param>
        /// <returns>An array of Fibonacci values.</returns>
        public static int[] FibonacciValues(int sequenceLength)
        {
            int[] fibonacci = new int[sequenceLength];
            fibonacci[0] = 0;
            fibonacci[1] = 1;
            for (int index = 2; index < sequenceLength; index++)
            {
                fibonacci[index] = fibonacci[index - 2] + fibonacci[index - 1];
            }
            return fibonacci;
        }

        /// <summary>It calculates the Nth prime number.</summary>
        /// <param name="index">The index of the prime number you want.</param>
        /// <returns>An integer of the calculated prime number.</returns>
        public static int NthPrimeNumber(int index)
        {
            int count = 0;
            int value = 0;
            int increment = 0;

            while (count != index)
            {
                if (Maths.IsPrime(increment))
                {
                    value = increment;
                    count++;
                    increment++;
                }
                else increment++;
            }

            return value;
        }

        /// <summary>It calculates an array of prime numbers between two values.</summary>
        /// <param name="lowBoundary">The lower bound range</param>
        /// <param name="highBoundary">The upper bound range</param>
        /// <returns>An array of prime integers between the bounds.</returns>
        public static int[] PrimeNumbers(int lowBoundary, int highBoundary)
        {
            List<int> list = new List<int>();
            for (int i = lowBoundary; i < highBoundary; i++)
            {
                if (Maths.IsPrime(i)) list.Add(i);
            }
            return list.ToArray();
        }
    }
}