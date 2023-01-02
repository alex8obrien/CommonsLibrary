using System.IO;

namespace CommonsLibrary
{
    public class FileIO
    {
        /// <summary>This methods returns the number of lines in a file.</summary>
        /// <param name="filePath">It's the path of the file from the solution folder including the file extension</param>
        /// <returns>An integer of the number of lines in a file</returns>
        public static int TotalLines(string filePath)
        {
            using StreamReader r = new(filePath);
            int count = 0;
            while (r.ReadLine() != null) { count++; }
            return count;
        }
        
        /// <summary>It returns a string of a specific line in a file</summary>
        /// <param name="filePath">It's the path of the file from the solution folder including the file extension</param>
        /// <param name="lineNumber">The specific line you want returned</param>
        /// <returns>A line in a file as a string</returns>
        /// <exception cref="Exception">New exception - "Line not found"</exception>
        public static string LineAt(string filePath, int lineNumber) =>
            File.ReadLines(filePath).ElementAt(lineNumber) ?? throw new Exception("Line not found");
    }
}