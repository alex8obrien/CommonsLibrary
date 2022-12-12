using System.IO;
using System.Reflection;
using System.Text;

namespace CommonsLibrary
{
    public class Logs
    {
        public static void LogWrite(string logMessage)
        {
            string pathString = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty;
            
            if (!File.Exists(pathString + @"\Logs\log.txt"))
            {
                var fs = File.Create(pathString + @"\Logs\log.txt");
                fs.Close();
            }
    
            using StreamWriter writer = File.AppendText(pathString + @"\Logs\log.txt");
            { Log(logMessage, writer); }
        }

        private static void Log(string logMessage, TextWriter txtWriter)
        { //This is the method that writes to the log file
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Log Entry : ");
            sb.AppendLine($"{DateTime.Now.ToLongDateString()}/{DateTime.Now.ToLongTimeString()}");
            sb.AppendLine(": ");
            sb.AppendLine($"{logMessage}");
            txtWriter.WriteLine(sb.ToString());
        }
    }
}