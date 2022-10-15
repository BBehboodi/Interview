using System.Text;

namespace Interview.SOLID.LiskovSubstitution.BadImp;

internal class SqlFileManager
{
    public string GetTextFromFiles(SqlFile[] sqlFiles)
    {
        var text = new StringBuilder();
        foreach (var sqlFile in sqlFiles)
        {
            text.Append(sqlFile.LoadText());
        }
        return text.ToString();
    }

    public void SaveTextIntoFiles(SqlFile[] sqlFiles)
    {
        foreach (var sqlFile in sqlFiles)
        {
            if (sqlFile is ReadOnlySqlFile)
            {
                continue;
            }

            sqlFile.SaveText();
        }
    }
}
