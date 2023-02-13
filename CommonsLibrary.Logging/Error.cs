namespace CommonsLibrary.Logging
{
    public class Error : LogBuilder
    {
        public Error(string error, string logMessage)
        {
            log = new Logs("ERR", error, logMessage);
        }

        public override void BuildLogMessage()
        {
        }

        public override void BuildError()
        {
        }
    }
}