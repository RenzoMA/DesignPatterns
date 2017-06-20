using AdapterPattern.Client;
using System.IO;
using System.Threading.Tasks;

namespace AdapterPattern.Adapter
{
    public interface IFileAdapter
    {
        Task<Document> Upload(Stream fileStream, DocumentType documentType);
    } 
}