using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Lib
{
    class FileManager
    {
        private readonly IFileAdapter _fileAdapter;

        public FileManager(IFileAdapter fileAdapter)
        {
            _fileAdapter = fileAdapter;
        }

        public bool Save(Stream dataStream)
        {
            var fileUrl =_fileAdapter.Upload(dataStream);
            // more operations.
            return true;
        }
    }
}
