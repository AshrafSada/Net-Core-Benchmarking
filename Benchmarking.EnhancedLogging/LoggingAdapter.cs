using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Benchmarking.EnhancedLogging;
public class LoggingAdapter<T> : ILoggingAdapter<T>
{
    private readonly ILogger _logger;

    public LoggingAdapter(ILogger logger)
    {
        _logger = logger;
    }

    public void LogInformation(string message)
    {
        if (_logger.IsEnabled(LogLevel.Information))
            _logger.LogInformation(message);
    }

    public void LogInformation<T0>(string message, T0 arg0)
    {
        if(_logger.IsEnabled(LogLevel.Information))
            _logger.LogInformation(message, arg0);
    }

    public void LogInformation<T0, T1>(string message, T0 arg0, T1 arg1)
    {
        if (_logger.IsEnabled(LogLevel.Information))
            _logger.LogInformation(message, arg0, arg1);
    }

    public void LogInformation<T0, T1, T2>(string message, T0 arg0, T1 arg1, T2 arg2)
    {
        if (_logger.IsEnabled(LogLevel.Information))
            _logger.LogInformation(message, arg0, arg1, arg2);
    }
}

// logging adapter with parameters
public interface ILoggingAdapter<T>
{
    void LogInformation(string message);
    void LogInformation<T0>(string message, T0 arg0);
    void LogInformation<T0, T1>(string message, T0 arg0, T1 arg1);
    void LogInformation<T0, T1, T2>(string message, T0 arg0, T1 arg1, T2 arg2);
}