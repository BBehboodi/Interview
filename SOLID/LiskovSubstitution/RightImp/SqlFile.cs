namespace Interview.SOLID.LiskovSubstitution.RightImp;

internal class SqlFile : IWritableSqlFile, IReadableSqlFile
{
    public string LoadText()
    {
        return string.Empty;
    }

    public void SaveText()
    {
    }
}
