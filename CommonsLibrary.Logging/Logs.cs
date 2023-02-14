using System.IO;
using System;
using System.Reflection;

namespace CommonsLibrary.Logging
{
    public class Logs
    {
        private readonly DateTime _dt;
        private readonly string _logType;
        private readonly string _error;
        private readonly string _logMessage;

        public Logs(string logType, string error, string message)
        {
            _dt = DateTime.Now;
            _logType = logType;
            _error = error;
            _logMessage = message;
        }

        public void WriteToFile(string path)
        {
            path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\" + path;
            if (string.IsNullOrEmpty(path) || !File.Exists(path)) throw new ArgumentNullException(path, "Path is null, empty or incorrect");

            using StreamWriter writer = new(path, true);
            writer.WriteLine($"[{_logType} {_dt}] {_error}: {_logMessage}");
        }
    }
}