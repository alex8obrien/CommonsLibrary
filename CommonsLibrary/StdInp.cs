﻿using System;
using System.Globalization;

namespace CommonsLibrary
{
    /// <summary>This class can return input from the console.</summary>
    /// <remarks>Requires the 'System.Console' package.</remarks>
    public static class StdInp
    {
        /// <summary>Used to retrieve a string input from the console.</summary>
        /// <param name="msg">The message to be displayed to the user.</param>
        /// <returns>The string input by the user.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="msg" /> is <see langword="null" />.</exception>
        public static string Input(string msg)
        {
            Console.Write($"{msg}: ");
            return Console.ReadLine() ?? string.Empty;
        }

        /// <summary>Used to retrieve an integer based input from the console that is between a range of values.</summary>
        /// <param name="msg">The message to be displayed to the user.</param>
        /// <param name="lowerBound">The lower bound of the range.</param>
        /// <param name="upperBound">The upper bound of the range.</param>
        /// <returns>The integer input by the user.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="msg" /> is <see langword="null" />.</exception>
        public static int InputIntInBound(string msg, int lowerBound, int upperBound)
        {
            int output;
            bool isInt;
            do
            {
                isInt = int.TryParse(Input($"{msg} ({lowerBound}-{upperBound})"), out output);
            } while (!isInt || output < lowerBound || upperBound < output);
            return output;
        }

        /// <summary>This method can be used to retrieve an integer based input from the console.</summary>
        /// <param name="msg">The message to be displayed to the user.</param>
        /// <returns>The integer input by the user.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="msg" /> is <see langword="null" />.</exception>
        public static int InputInt(string msg)
        {
            int output;
            bool isInt;
            do
            {
                isInt = int.TryParse(Input(msg), out output);
            } while (!isInt);
            return output;
        }

        /// <summary>This method can be used to retrieve a bool input from the console from Yes or No.</summary>
        /// <param name="msg">The message to be displayed to the user.</param>
        /// <returns>The bool input by the user.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="msg" /> is <see langword="null" />.</exception>
        // ReSharper disable once InconsistentNaming
        public static bool InputYNAsBool(string msg)
        {
            string inp;

            do
            {
                inp = Input($"{msg} (y/n)").ToUpper();
            } while (inp != "Y" && inp != "N" && inp != "YES" && inp != "NO");

            return inp == "Y" || inp == "YES";
        }

        /// <summary>Converts user input to a delimited string array.</summary>
        /// <param name="msg">The input message displayed to the user.</param>
        /// <param name="delimiter">The delimiter used to separate the string.</param>
        /// <returns>A string array created from user input.</returns>
        public static string[] InputDelimitedArray(string msg, char delimiter)
        {
            string input = Input(msg);
            string[] array = input.Split(delimiter);
            return array;
        }

        /// <summary>Gets formatted DateTime from the Console</summary>
        /// <param name="msg">The message displayed to the user</param>
        /// <param name="pattern">The DateTime pattern shown to the user</param>
        /// <param name="culture">The culture-specific information for the DateTime</param>
        /// <returns>A DateTime object representing the string inputted DateTime</returns>
        public static DateTime GetDateTime(string msg, string pattern, CultureInfo culture)
        {
            bool valid;
            DateTime result;

            do
            {
                string input = Input($"{msg} ({pattern})");
                valid = DateTime.TryParseExact(input, pattern, culture, DateTimeStyles.AllowWhiteSpaces, out result);

                if (!valid)
                    Console.WriteLine("Invalid date/time format.");

            } while (!valid);

            return result;
        }

        /// <summary>Gets user inputted DateTime and converts it to a unix timestamp</summary>
        /// <param name="msg">The message displayed to the user</param>
        /// <param name="pattern">The DateTime pattern shown to the user</param>
        /// <param name="culture">The culture-specific information for the DateTime</param>
        /// <returns>A unix timestamp representing the inputted DateTime</returns>
        public static long GetUnixDateTime(string msg, string pattern, CultureInfo culture)
        {
            DateTime dt = GetDateTime(msg, pattern, culture);
            return ((DateTimeOffset)dt).ToUnixTimeSeconds();
        }
    }
}