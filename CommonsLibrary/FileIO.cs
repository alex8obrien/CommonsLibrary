using System.IO;
using System.Linq;

namespace CommonsLibrary
{
    public static class FileIO
    {
        /// <summary>Returns a string of the solution folder</summary>
        public static string FilePath { get; } =
            Directory.GetParent(Directory.GetCurrentDirectory().Split(@"\bin")[0]) + @"\";

        /// <summary>Calculates the number of lines in a file.</summary>
        /// <param name="filePath">It's the path of the file from the solution folder including the file extension.</param>
        /// <returns>An integer of the number of lines in a file.</returns>
        /// <exception cref="System.ArgumentException">
        /// <paramref name="filePath" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
        /// <exception cref="System.ArgumentNullException">
        /// <paramref name="filePath" /> is <see langword="null" />.</exception>
        /// <exception cref="System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length.</exception>
        /// <exception cref="System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="System.IO.IOException">An I/O error occurred while opening the file.</exception>
        /// <exception cref="System.UnauthorizedAccessException">
        ///         <paramref name="filePath" /> specified a file that is read-only.
        /// -or-
        /// This operation is not supported on the current platform.
        /// -or-
        /// <paramref name="filePath" /> specified a directory.
        /// -or-
        /// The caller does not have the required permission.</exception>
        /// <exception cref="System.IO.FileNotFoundException">The file specified in <paramref name="filePath" /> was not found.</exception>
        /// <exception cref="System.NotSupportedException">
        /// <paramref name="filePath" /> is in an invalid format.</exception>
        /// <exception cref="System.Security.SecurityException">The caller does not have the required permission.</exception>
        public static int TotalLines(string filePath) =>
            File.ReadAllLines(FilePath + filePath).Length;

        /// <summary>It returns a string of a specific line in a file from a 0 based index</summary>
        /// <param name="filePath">It's the path of the file from the solution folder including the file extension</param>
        /// <param name="lineNumber">The specific line you want returned</param>
        /// <returns>A line in a file as a string</returns>
        /// <exception cref="System.ArgumentException">
        /// <paramref name="filePath" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
        /// <exception cref="System.ArgumentNullException">
        /// <paramref name="filePath" /> is <see langword="null" />.</exception>
        /// <exception cref="System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length.</exception>
        /// <exception cref="System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="System.IO.IOException">An I/O error occurred while opening the file.</exception>
        /// <exception cref="System.UnauthorizedAccessException">
        ///         <paramref name="filePath" /> specified a file that is read-only.
        /// -or-
        /// This operation is not supported on the current platform.
        /// -or-
        /// <paramref name="filePath" /> specified a directory.
        /// -or-
        /// The caller does not have the required permission.</exception>
        /// <exception cref="System.IO.FileNotFoundException">The file specified in <paramref name="filePath" /> was not found.</exception>
        /// <exception cref="System.NotSupportedException">
        /// <paramref name="filePath" /> is in an invalid format.</exception>
        /// <exception cref="System.Security.SecurityException">The caller does not have the required permission.</exception>
        /// <exception cref="System.IndexOutOfRangeException">The line you selected is not valid</exception>
        public static string LineAt(string filePath, int lineNumber) =>
            File.ReadLines(FilePath + filePath).ElementAt(lineNumber);

        /// <summary>It returns an integer of all the characters in a file</summary>
        /// <param name="filePath">It's the path of the file from the solution folder including the file extension</param>
        /// <returns>An integer of all the characters in a file</returns>
        ///         /// <exception cref="System.ArgumentException">
        /// <paramref name="filePath" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
        /// <exception cref="System.ArgumentNullException">
        /// <paramref name="filePath" /> is <see langword="null" />.</exception>
        /// <exception cref="System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length.</exception>
        /// <exception cref="System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="System.IO.IOException">An I/O error occurred while opening the file.</exception>
        /// <exception cref="System.UnauthorizedAccessException">
        ///         <paramref name="filePath" /> specified a file that is read-only.
        /// -or-
        /// This operation is not supported on the current platform.
        /// -or-
        /// <paramref name="filePath" /> specified a directory.
        /// -or-
        /// The caller does not have the required permission.</exception>
        /// <exception cref="System.IO.FileNotFoundException">The file specified in <paramref name="filePath" /> was not found.</exception>
        /// <exception cref="System.NotSupportedException">
        /// <paramref name="filePath" /> is in an invalid format.</exception>
        /// <exception cref="System.Security.SecurityException">The caller does not have the required permission.</exception>
        public static int TotalChars(string filePath) =>
            File.ReadAllLines(FilePath + filePath).Sum(line => line.Length);
    }
}