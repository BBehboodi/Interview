using System;
using System.IO;

namespace Interview.SOLID.DependencyInversion.BadImp;

internal class DataExporter
{
    public void ExportDataFromFile()
    {
        try
        {
            // Code to export data from files to database.  
        }
        catch (IOException exception)
        {
            new ExceptionLogger().LogIntoDataBase(exception);
        }
        catch (Exception exception)
        {
            new ExceptionLogger().LogIntoFile(exception);
        }
    }
}
