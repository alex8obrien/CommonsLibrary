using System.IO;
using System.Reflection;
using System;

namespace CommonsLibrary.Logging
{
    public class Logs
    {
        private DateTime _dt;
        private string _LogType;
        private string _LogMessage;

        public Logs(string logType, string message)
        {
            _dt = DateTime.Now;
            _LogType = logType;
            _LogMessage = message;
        }

        public void Show()
        {
            Console.WriteLine($"DT: {_dt}");
            Console.WriteLine($"Logs Type: {_LogType}");
            Console.WriteLine($"Logs Message: {_LogMessage}");
        }
    }
}