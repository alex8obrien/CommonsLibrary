using System;

namespace CommonsLibrary
{
    /// <summary>Contains methods for standard output data.</summary>
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
        public static void WriteLineColourMessage(string msg, ConsoleColor colour) => WriteColourMessage($"{msg}\n", colour);
    }
}