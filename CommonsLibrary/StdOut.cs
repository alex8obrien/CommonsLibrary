using System;
using System.Collections.Generic;
using System.Text;

namespace CommonsLibrary
{
    /// <summary>Contains methods for standard output data.</summary>
    /// <remarks>It requires the use of the 'System.Console' package.</remarks>
    public static class StdOut
    {
        /// <summary>Used to write messages to the console in colour without a new line</summary>
        /// <param name="msg"></param>
        /// <param name="colour"></param>
        public static void WriteColourMessage(string msg, ConsoleColor colour)
        {
            Console.ForegroundColor = colour;
            Console.Write(msg);
            Console.ResetColor();
        }

        /// <summary>Used to write messages to the console in colour with a new line</summary>
        /// <param name="msg"></param>
        /// <param name="colour"></param>
        public static void WriteLineColourMessage(string msg, ConsoleColor colour) =>
            WriteColourMessage($"{msg}\n", colour);

        /// <summary>Used to build and display data</summary>
        /// <param name="headers">An array of the headers</param>
        /// <param name="data">A 2D array of the data you want displaying</param>
        public static void PrintTable(string[] headers, string[,] data)
        {
            int[] maxColumnWidth = new int[headers.Length];

            // Find max column width
            for (int i = 0; i < headers.Length; i++)
            {
                maxColumnWidth[i] = headers[i].Length;
            }

            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    if (data[i, j].Length > maxColumnWidth[j])
                    {
                        maxColumnWidth[j] = data[i, j].Length;
                    }
                }
            }

            foreach (string header in headers)
            {
                Console.Write($"| {header} ");
                int diff = maxColumnWidth[Array.IndexOf(headers, header)] - header.Length;
                for (int i = 0; i < diff; i++)
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine("|");

            for (int i = 0; i < headers.Length; i++)
            {
                Console.Write("|-");
                for (int j = 0; j < maxColumnWidth[i]; j++)
                {
                    Console.Write("-");
                }

                Console.Write("-");
            }

            Console.WriteLine("|");

            for (int i = 0; i < data.GetLength(0); i++)
            {
                Console.Write("|");
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write($" {data[i, j]}");

                    int diff = maxColumnWidth[j] - data[i, j].Length;
                    for (int k = 0; k < diff; k++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(" |");
                }

                Console.WriteLine("");
            }
        }

        /// <summary>
        /// Method used to create the lines for the table
        /// </summary>
        /// <param name="maxWidths">Max width of each column</param>
        /// <returns>A StringBuilder that contains the line to separate the headers and data</returns>
        private static StringBuilder CreateRule(IEnumerable<int> maxWidths)
        {
            StringBuilder builder = new StringBuilder();

            foreach (int maxWidth in maxWidths)
            {
                builder.Append("|-");
                for (int i = 0; i < maxWidth; i++)
                {
                    builder.Append('-');
                }
                builder.Append('-');
            }

            builder.AppendLine("|");
            return builder;
        }
    }
}