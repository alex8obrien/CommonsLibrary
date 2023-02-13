using System;

namespace CommonsLibrary.Logging
{
    class Warning : LogBuilder
    {
        public Warning(string logMessage)
        {
            log = new Logs("WRN", logMessage);
        }

        public override void BuildLogMessage()
        { }
    }
}