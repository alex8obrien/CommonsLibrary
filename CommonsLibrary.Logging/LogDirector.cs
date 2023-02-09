namespace CommonsLibrary.Logging
{
    public static class LogDirector
    {
        public static LogsAgent MakeLog(LogBuilder logBuilder, string exceptionType)
        {
            logBuilder.CreateNewLog();
            logBuilder.SetDateTime();
            logBuilder.SetLogType();
            logBuilder.SetLogMessage(exceptionType);

            return logBuilder.GetLog();
        }
    }
}