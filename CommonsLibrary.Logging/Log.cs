using System;

namespace CommonsLibrary.Logging
{
    // ReSharper disable once InconsistentNaming
    public class Log : LogBuilder
    {
        public override void SetDateTime()
        {
            LogsAgentObject.DateTime = DateTime.UtcNow;
        }

        public override void SetLogType()
        {
            LogsAgentObject.LogType = "LOG";
        }

        public override void SetLogMessage(string exceptionType)
        {
            LogsAgentObject.LogMessage = exceptionType;
        }
    }
}