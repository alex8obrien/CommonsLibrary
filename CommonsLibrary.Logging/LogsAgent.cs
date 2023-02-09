using System.IO;
using System.Reflection;
using System;

namespace CommonsLibrary.Logging
{
    public class LogsAgent
    {
        public DateTime DateTime { get; set; }
        public string LogType { get; set; }
        public string LogMessage { get; set; }

        public void WriteLog(string path)
        {
            path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\" + path;

            if (string.IsNullOrEmpty(path) || !File.Exists(path)) throw new ArgumentNullException(path, "Path is null, empty or incorrect");

            using StreamWriter writer = new(path, true);
            writer.WriteLine($"[{LogType} {DateTime}]: {LogMessage}");
        }
    }
}