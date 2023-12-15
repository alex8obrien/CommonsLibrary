using System;
using System.IO;

namespace CommonsLibrary.Logging
{
    public class Log
    {
        private readonly string _filePath;
        private static Log? _logger;

        private Log(string filePath) => _filePath = filePath;
        public static Log GetLogger(string filePath) => _logger ??= new Log(filePath);

        private void WriteLog(LogLevel level, string message, Exception? exception = null)
        {
            using StreamWriter writer = new StreamWriter(_filePath, true);
            writer.WriteLine($"{DateTime.Now} {level} {exception} {message}");
        }

        public void Info(string message) =>
            WriteLog(LogLevel.Info, message);
            
        public void Warning(string message) =>
            WriteLog(LogLevel.Warning, message);

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