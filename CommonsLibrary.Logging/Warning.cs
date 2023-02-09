using System;

namespace CommonsLibrary.Logging
{
    public class Warning : LogBuilder
    {
        public override void SetDateTime()
        {
            LogsAgentObject.DateTime = DateTime.UtcNow;
        }

        public override void SetLogType()
        {
            LogsAgentObject.LogType = "WRN";
        }

        public override void SetLogMessage(string exceptionType)
        {
            LogsAgentObject.LogMessage = exceptionType;
        }
    }
}