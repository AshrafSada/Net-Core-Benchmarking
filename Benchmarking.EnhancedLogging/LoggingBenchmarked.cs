using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.Logging;

namespace Benchmarking.EnhancedLogging;

[MemoryDiagnoser]
public class LoggingBenchmarked
{
    // parameterized logging message
    public const string LOG_MESSAGE_PARAMETERS = "Log message with parameters {0}, {1}, {2}";

    // logging message no parameters
    public const string LOG_MESSAGE = "Log message without parameters";

    private readonly ILoggingAdapter<LoggingBenchmarked> _loggingAdapter;

    // _logger factory with console logging and log level set to warning
    private readonly ILoggerFactory _loggerFactory = LoggerFactory.Create(bld =>
    {
        bld.AddConsole().SetMinimumLevel(LogLevel.Information);
    });

    // inject ILogger into un-parameterized constructor
    private readonly ILogger<LoggingBenchmarked> _logger;

    public LoggingBenchmarked()
    {
        // create _logger instance with _logger factory as parameter
        _logger = new Logger<LoggingBenchmarked>(_loggerFactory);
        _loggingAdapter = new LoggingAdapter<LoggingBenchmarked>(_logger);
    }

    // benchmark method for logging without parameters
    [Benchmark]
    public void LogWithoutParameters()
    {
        // if the log-level is higher than the log-level of the message, the message is not logged
        _logger.LogInformation(LOG_MESSAGE);
    }

    // benchmark method for logging with parameters
    [Benchmark]
    public void LogWithParameters()
    {
        // if the log-level is higher than the log-level of the message, the message is not logged
        _logger.LogInformation(LOG_MESSAGE_PARAMETERS, 1, 2, 3);
    }

    // benchmark method for logging with parameters with if
    [Benchmark]
    public void LogWithParametersIf()
    {
        if (_logger.IsEnabled(LogLevel.Information))
        {
            _logger.LogInformation(LOG_MESSAGE_PARAMETERS, 11, 22, 33);
        }
    }

    // logging random data (random number)
    [Benchmark]
    public void LogRandomData()
    {
        _logger.LogInformation("Log random numbers{RandomNumber}", Random.Shared.Next());
    }

    // logging with logging adapter, because of the use of generics no allocation on the heap will happen
    [Benchmark]
    public void LogWithLoggingAdapter()
    {
        _loggingAdapter.LogInformation(LOG_MESSAGE_PARAMETERS, 11, 22, 33);
    }

    // logging with defined custom message
    [Benchmark]
    public void LogWithCustomMessage()
    {
        _logger.LogBenchmarkDefinedMessage(11, 22, 33);
    }
}