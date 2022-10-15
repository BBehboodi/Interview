using System;
using System.IO;

namespace Interview.SOLID.DependencyInversion.RightImp;

internal class DataExporter
{
    public void ExportDataFromFile()
    {
        try
        {
            // Code to export data from files to database.  
        }
        catch (IOException ex)
        {
            var exceptionLogger = new ExceptionLogger(new DbLogger());
            exceptionLogger.LogException(ex);
        }
        catch (Exception ex)
        {
            var exceptionLogger = new ExceptionLogger(new FileLogger());
            exceptionLogger.LogException(ex);
        }
    }
}
