using System;

namespace CommonsLibrary
{
    /// <summary>This class can return input from the console.</summary>
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

            return inp is "Y" or "YES";
        }
    }
}