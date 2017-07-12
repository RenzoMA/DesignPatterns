using AdapterPattern.Entities;
using System.IO;
using System.Threading.Tasks;

namespace AdapterPattern.Adapter
{
    public interface IFile
    {
        Task<Document> Upload(Stream fileStream, DocumentType documentType);
    } 
}