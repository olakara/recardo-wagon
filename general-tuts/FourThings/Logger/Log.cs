namespace FourThings.Logger
{
    public static partial class Log
    {
        [LoggerMessage(EventId = 0, Level = LogLevel.Information, Message = "This is logging from: {basic}")]
        public static partial void CustomLog(this ILogger logger, string basic);
    }
}