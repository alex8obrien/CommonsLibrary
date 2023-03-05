using System;
using System.Collections.Generic;

namespace CommonsLibrary.Maths
{
    public static class Sequences
    {
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

        public static int[] PrimeNumbers(int lowBoundary, int highBoundary)
        {
            List<int> list = new();
            for (int i = lowBoundary; i < highBoundary; i++)
            {
                if (Maths.IsPrime(i)) list.Add(i);
            }
            return list.ToArray();
        }
    }
}