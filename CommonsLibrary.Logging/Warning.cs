namespace CommonsLibrary.Logging
{
    class Warning : LogBuilder
    {
        public Warning(string error, string logMessage)
        {
            log = new Logs("WRN", error, logMessage);
        }

        public override void BuildLogMessage()
        { }

        public override void BuildError()
        { }
    }
}