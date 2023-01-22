using System;

namespace StdOut
{
    internal class StdOut
    {
        /// <summary>
        /// Creates a table from Headers and Data in Array format
        /// <param name="Headers">Is the headers for the table in an array</param>
        /// <param name="Data">Is the data for the table in an array</param>
        /// </summary>
        public static void ArrayTable(string[] Headers, string[,] Data)
        {
            // Makes max width for each column
            int[] largest = new int[Headers.Length];

            // Makes the maximum width equal to each header
            for (int i = 0; i < Headers.Length; i++)
            { largest[i] = Headers[i].Length; }

            // Makes the maximum width equal to each data if its bigger
            for (int i = 0; i < Data.GetLength(0); i++)
            {
                for (int j = 0; j < Data.GetLength(1); j++)
                {
                    if (Data[i, j].Length > largest[j])
                    {
                        largest[j] = Data[i, j].Length;
                    }
                }
            }

            WriteHeaders(Headers, largest);
            Underline(largest);
            Console.Write("\n");
            WriteData(Data, largest);
        }

        /// <summary>
        /// Writes the headers for the table with equal spacing
        /// </summary>
        /// <param name="Headers">The array containing the header strings</param>
        /// <param name="MaxWidth">The maximum with for each column</param>
        private static void WriteHeaders(string[] Headers, int[] MaxWidth)
        {
            // Writes the underline
            Console.Write("|");
            for (int i = 0; i < MaxWidth.Length; i++)
            {
                Console.Write(" ");

                if (MaxWidth[i] % 2 == 0)
                {
                    int width = MaxWidth[i];
                    width -= Headers[i].Length;
                    width /= 2;

                    // Write first half of spaces
                    for (int j = 0; j < width; j++)
                    { Console.Write(" "); }

                    // Write header
                    Console.Write(Headers[i]);

                    if (Headers[i].Length % 2 == 0)
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
                    int width = MaxWidth[i];
                    width -= Headers[i].Length;
                    width /= 2;

                    // Write first half of spaces
                    for (int j = 0; j < width; j++)
                    { Console.Write(" "); }

                    // Write header
                    Console.Write(Headers[i]);

                    if (Headers[i].Length % 2 == 0)
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
        /// <param name="MaxWidth">It's the maximum width of each column/param>
        private static void Underline(int[] MaxWidth)
        {
            // Writes the underline
            Console.Write("\n|");
            for (int i = 0; i < MaxWidth.Length; i++)
            {
                for (int j = 0; j < MaxWidth[i] + 2; j++)
                {
                    Console.Write("-");
                }
                Console.Write("|");
            }
        }

        /// <summary>
        /// It writes the data to the console
        /// </summary>
        /// <param name="Data">It's a 2D array that contains data for the table</param>
        /// <param name="MaxWidth">It's the maximum width of each column</param>
        private static void WriteData(string[,] Data, int[] MaxWidth)
        {
            for (int i = 0; i < Data.GetLength(0); i++)
            {
                Console.Write("|");
                for (int j = 0; j < Data.GetLength(1); j++)
                {
                    if (Data[i, j].Length == MaxWidth[j])
                    {
                        Console.Write(" " + Data[i, j]);
                        Console.Write(" |");
                        continue;
                    }

                    if (Data[i, j].Length % 2 == 0)
                    {
                        int numberOfSpaces = MaxWidth[j] - Data[i, j].Length;

                        for (int k = 0; k < numberOfSpaces / 2; k++)
                        { Console.Write(" "); }

                        Console.Write(Data[i, j]);

                        for (int k = 0; k < numberOfSpaces / 2; k++)
                        { Console.Write(" "); }
                    }
                    else
                    {
                        int numberOfSpaces = MaxWidth[j] - Data[i, j].Length;

                        for (int k = 0; k <= Math.Floor(numberOfSpaces / 2f); k++)
                        { Console.Write(" "); }

                        Console.Write(Data[i, j]);

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