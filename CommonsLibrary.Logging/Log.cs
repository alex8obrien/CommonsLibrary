using System;

namespace CommonsLibrary.Logging
{
    public class Log : LogBuilder
    {
        public Log(string logMessage)
        {
            log = new Logs("LOG", logMessage);
        }

        public override void BuildLogMessage()
        { }
    }
}