namespace CommonsLibrary.Logging
{
    public abstract class LogBuilder
    {
        protected LogsAgent LogsAgentObject;

        public abstract void SetDateTime();
        public abstract void SetLogType();
        public abstract void SetLogMessage(string exceptionType);

        public void CreateNewLog()
        {
            LogsAgentObject = new LogsAgent();
        }

        public LogsAgent GetLog()
        {
            return LogsAgentObject;
        }
    }
}