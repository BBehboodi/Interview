namespace Interview.SOLID.LiskovSubstitution.RightImp;

internal class ReadOnlySqlFile : IReadableSqlFile
{
    public string LoadText()
    {
        return string.Empty;
    }
}
