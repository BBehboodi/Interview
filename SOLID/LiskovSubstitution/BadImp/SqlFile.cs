namespace Interview.SOLID.LiskovSubstitution.BadImp;
internal class SqlFile
{
    public string LoadText()
    {
        return string.Empty;
    }

    public virtual void SaveText()
    { 
    }
}
