using AdapterPattern.Adapter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Client
{
    class FileManager
    {
        private readonly IFileAdapter _fileAdapter;
        private readonly DocumentType _documentType;

        public FileManager(IFileAdapter fileAdapter, DocumentType documentType)
        {
            _fileAdapter = fileAdapter;
            _documentType = documentType;
        }

        public async Task<bool> Save(Stream dataStream)
        {
            var fileUrl = await _fileAdapter.Upload(dataStream, _documentType);
            Console.WriteLine("----- File successfully uploaded -----");
            return true;
        }
    }
}
