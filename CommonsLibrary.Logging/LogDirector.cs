namespace CommonsLibrary.Logging
{
    public class Director
    {
        public void Construct(LogBuilder logBuilder)
        {
            logBuilder.BuildLogMessage();
            logBuilder.BuildError();
        }
    }
}