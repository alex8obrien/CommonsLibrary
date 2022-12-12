using System.IO;
using System.Reflection;
using System.Text;

namespace CommonsLibrary
{
    public class Logs
    {
        /// <summary>This method will create a log file if it doesn't exist and then it will write the log to the file.
        ///It can also be called manually to write a custom log to the log file</summary>
        /// <param name="logMessage">The message that will be written to the log</param>
        public static void LogWrite(string logMessage)
        {
            string pathString = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty;
            
            try
            {
                if (!File.Exists(pathString + @"\Logs\log.txt"))
                {
                    var fs = File.Create(pathString + @"\Logs\log.txt");
                    fs.Close();
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Bruh even logging failed");
            }
    
            using StreamWriter writer = File.AppendText(pathString + @"\Logs\log.txt");
            { Log(logMessage, writer); }
        }

        /// <summary>This method will write the log to the file</summary>
        /// <param name="logMessage">The message that will be written to the log</param>
        /// <param name="txtWriter">The class that will be used to write the log to the file</param>
        private static void Log(string logMessage, TextWriter txtWriter)
        { //This is the method that writes to the log file
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Log Entry : ");
            sb.AppendLine($"{DateTime.Now.ToLongDateString()}/{DateTime.Now.ToLongTimeString()}");
            sb.AppendLine(": ");
            sb.AppendLine($"{logMessage}");
            txtWriter.WriteLine(sb.ToString());
        }

        /// <summary>This will create a log for you with the exception information and then it will write the log to the file</summary>
        /// <param name="e">The exception that occured</param>
        public static void LogBuilder(Exception e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Exception Found:\nType: {e.GetType().FullName}");
            sb.AppendFormat($"\nMessage: {e.Message}");
            sb.AppendFormat($"\nSource: {e.Source}");
            sb.AppendFormat($"\nStacktrace: {e.StackTrace}");
            LogWrite(sb.ToString());
        }
    }
}