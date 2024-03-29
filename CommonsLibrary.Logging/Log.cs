using System;
using System.IO;

namespace CommonsLibrary.Logging
{
    /// <summary>
    /// Log container class
    /// </summary>
    /// <remarks>Depends on 'System' & 'System.IO' packages.</remarks>
    public class Log
    {
        private readonly string _filePath;
        private static Log? _logger;

        private Log(string filePath) => _filePath = filePath;
        /// <summary>
        /// Singleton used to retrieve the active logger
        /// </summary>
        /// <param name="filePath">Full file path of the log file</param>
        /// <returns>Instance of the Log class</returns>
        public static Log GetLogger(string filePath) => _logger ??= new Log(filePath);

        private void WriteLog(LogLevel level, string message, Exception? exception = null)
        {
            using StreamWriter writer = new StreamWriter(_filePath, true);
            writer.WriteLine($"{DateTime.Now} {level} {exception} {message}");
        }

        /// <summary>
        /// Used to create Info level logs
        /// </summary>
        /// <param name="message">Message to be written</param>
        public void Info(string message) =>
            WriteLog(LogLevel.Info, message);
            
        /// <summary>
        /// Used to create Warning level logs
        /// </summary>
        /// <param name="message">Message to be written</param>
        public void Warning(string message) =>
            WriteLog(LogLevel.Warning, message);

        /// <summary>
        /// Used to create Error level logs
        /// </summary>
        /// <param name="message">Message to be written</param>
        /// <param name="exception">Exception to be logged</param>
        public void Error(string message, Exception exception) =>
            WriteLog(LogLevel.Error, message, exception);
        
        private enum LogLevel
        {
            Info,
            Warning,
            Error,
        }
    }
}