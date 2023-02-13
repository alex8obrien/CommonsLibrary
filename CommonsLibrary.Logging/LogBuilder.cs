namespace CommonsLibrary.Logging
{
    public abstract class LogBuilder
    {
        protected Logs log;

        public Logs Log => log;

        public abstract void BuildLogMessage();

    }
}