using System.IO;

namespace Interview.SOLID.LiskovSubstitution.BadImp;

internal class ReadOnlySqlFile : SqlFile
{
    public override void SaveText()
    {
        throw new IOException("Can't Save");
    }
}
