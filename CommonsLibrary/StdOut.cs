using System;
using System.Collections.Generic;

namespace CommonsLibrary
{
    /// <summary>Contains methods for standard output data.</summary>
    public static class StdOut
    {
        /// <summary>
        /// Creates a table from Headers and Data in Array format
        /// <param name="headers">Is the headers for the table in an array</param>
        /// <param name="data">Is the data for the table in an array</param>
        /// </summary>
        public static void ArrayTable(string[] headers, string[,] data)
        {
            // Makes max width for each column
            int[] largest = new int[headers.Length];

            // Makes the maximum width equal to each header
            for (int i = 0; i < headers.Length; i++)
            { largest[i] = headers[i].Length; }

            // Makes the maximum width equal to each data if its bigger
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    if (data[i, j].Length > largest[j])
                    {
                        largest[j] = data[i, j].Length;
                    }
                }
            }

            WriteHeaders(headers, largest);
            Underline(largest);
            Console.Write("\n");
            WriteData(data, largest);
        }

        /// <summary>
        /// Writes the headers for the table with equal spacing
        /// </summary>
        /// <param name="headers">The array containing the header strings</param>
        /// <param name="maxWidth">The maximum with for each column</param>
        private static void WriteHeaders(IReadOnlyList<string> headers, IReadOnlyList<int> maxWidth)
        {
            // Writes the underline
            Console.Write("|");
            for (int i = 0; i < maxWidth.Count; i++)
            {
                Console.Write(" ");

                if (maxWidth[i] % 2 == 0)
                {
                    int width = maxWidth[i];
                    width -= headers[i].Length;
                    width /= 2;

                    // Write first half of spaces
                    for (int j = 0; j < width; j++)
                    { Console.Write(" "); }

                    // Write header
                    Console.Write(headers[i]);

                    if (headers[i].Length % 2 == 0)
                    {
                        // Write second half of spaces
                        for (int j = 0; j < width; j++)
                        { Console.Write(" "); }
                    }
                    else
                    {
                        // Write second half of spaces
                        for (int j = 0; j <= width; j++)
                        { Console.Write(" "); }
                    }
                }
                else
                {
                    int width = maxWidth[i];
                    width -= headers[i].Length;
                    width /= 2;

                    // Write first half of spaces
                    for (int j = 0; j < width; j++)
                    { Console.Write(" "); }

                    // Write header
                    Console.Write(headers[i]);

                    if (headers[i].Length % 2 == 0)
                    {
                        // Write second half of spaces
                        for (int j = 0; j <= width; j++)
                        { Console.Write(" "); }
                    }
                    else
                    {
                        // Write second half of spaces
                        for (int j = 0; j < width; j++)
                        { Console.Write(" "); }
                    }
                }

                Console.Write(" |");
            }
        }

        /// <summary>
        /// Underlines the headers in the table
        /// </summary>
        /// <param name="maxWidth">It's the maximum width of each column</param>
        private static void Underline(IEnumerable<int> maxWidth)
        {
            // Writes the underline
            Console.Write("\n|");
            foreach (int value in maxWidth)
            {
                for (int j = 0; j < value + 2; j++)
                {
                    Console.Write("-");
                }
                Console.Write("|");
            }
        }

        /// <summary>
        /// It writes the data to the console
        /// </summary>
        /// <param name="data">It's a 2D array that contains data for the table</param>
        /// <param name="maxWidth">It's the maximum width of each column</param>
        private static void WriteData(string[,] data, IReadOnlyList<int> maxWidth)
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                Console.Write("|");
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    if (data[i, j].Length == maxWidth[j])
                    {
                        Console.Write(" " + data[i, j]);
                        Console.Write(" |");
                        continue;
                    }

                    if (data[i, j].Length % 2 == 0)
                    {
                        int numberOfSpaces = maxWidth[j] - data[i, j].Length;

                        for (int k = 0; k <= numberOfSpaces / 2; k++)
                        { Console.Write(" "); }

                        Console.Write(data[i, j]);

                        for (int k = 0; k <= numberOfSpaces / 2; k++)
                        { Console.Write(" "); }
                    }
                    else
                    {
                        int numberOfSpaces = maxWidth[j] - data[i, j].Length;

                        for (int k = 0; k <= Math.Floor(numberOfSpaces / 2f); k++)
                        { Console.Write(" "); }

                        Console.Write(data[i, j]);

                        for (int k = 0; k < Math.Ceiling(numberOfSpaces / 2f); k++)
                        { Console.Write(" "); }
                    }

                    Console.Write(" |");
                }
                Console.Write("\n");
            }
        }
    }
}