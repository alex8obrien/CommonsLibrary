namespace CommonsLibrary.Logging
{
    class Director
    {
        public void Construct(LogBuilder logBuilder)
        {
            logBuilder.BuildLogMessage();
        }
    }
}