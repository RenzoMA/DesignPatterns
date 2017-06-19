using System.IO;

namespace AdapterPattern.Lib
{
    public interface IFileAdapter
    {
        string Upload(Stream fileStream);
    }
}