using System;

namespace Interview.SOLID.DependencyInversion.RightImp;

internal class ExceptionLogger
{
	private readonly ILogger _logger;

	public ExceptionLogger(ILogger logger)
	{
		_logger = logger;
	}

    public void LogException(Exception exception)
    {
        _logger.LogMessage(exception.ToString());
    }
}
