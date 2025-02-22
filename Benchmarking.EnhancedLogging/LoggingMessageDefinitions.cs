using Microsoft.Extensions.Logging;

namespace Benchmarking.EnhancedLogging;

public static class LoggingMessageDefinitions
{
    // define custom logging message
    private static readonly Action<ILogger, int, int, int, Exception?> CustomLoggingMessageDefinition =
        LoggerMessage.Define<int, int, int>(LogLevel.Information, new EventId(1009, "Benchmark"), "Log message with parameters {0}, {1}, {2}");

    // extension method for logging message with parameters
    public static void LogBenchmarkDefinedMessage(this ILogger logger, int arg0, int arg1, int arg2)
    {
        CustomLoggingMessageDefinition(logger, arg0, arg1, arg2, null);
    }
}