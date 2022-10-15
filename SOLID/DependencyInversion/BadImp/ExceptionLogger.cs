using System;

namespace Interview.SOLID.DependencyInversion.BadImp;

internal class ExceptionLogger
{
    public void LogIntoFile(Exception exception)
    {
        var fileLogger = new FileLogger();
        fileLogger.LogMessage(exception.ToString());
    }

    public void LogIntoDataBase(Exception exception)
    {
        var dbLogger = new DbLogger();
        dbLogger.LogMessage(exception.ToString());
    }
}
