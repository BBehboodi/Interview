using System.Text;

namespace Interview.SOLID.LiskovSubstitution.RightImp;

internal class SqlFileManager
{
    public string GetTextFromFiles(IReadableSqlFile[] sqlFiles)
    {
        var text = new StringBuilder();
        foreach (var sqlFile in sqlFiles)
        {
            text.Append(sqlFile.LoadText());
        }
        return text.ToString();
    }

    public void SaveTextIntoFiles(IWritableSqlFile[] sqlFiles)
    {
        foreach (var sqlFile in sqlFiles)
        {
            sqlFile.SaveText();
        }
    }
}
