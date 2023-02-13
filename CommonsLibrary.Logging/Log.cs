namespace CommonsLibrary.Logging
{
    public class Log : LogBuilder
    {
        public Log(string error, string logMessage)
        {
            log = new Logs("LOG", error,  logMessage);
        }

        public override void BuildLogMessage()
        { }

        public override void BuildError()
        { }
    }
}