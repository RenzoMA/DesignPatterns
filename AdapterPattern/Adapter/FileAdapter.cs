using AdapterPattern.Entities;
using AdapterPattern.Helpers;
using AdapterPattern.Library;
using AdapterPattern.Services;
using System;
using System.IO;
using System.Threading.Tasks;

namespace AdapterPattern.Adapter
{
    /// <summary>
    /// Adapter
    /// </summary>
    class FileAdapter : IFile
    {
        private CloudImageLoader _cloudImageLoader;
        public FileAdapter()
        {
            _cloudImageLoader = new CloudImageLoader();
        }
        public async Task<Document> Upload(Stream fileStream, DocumentType documentType)
        {
            var service = new MyCompanyService();
            var document = new Document();

            Console.WriteLine("----- Upload has started -----");
            Console.WriteLine("----- DocumentType: {0} -----", documentType.ToString());

            if (documentType == DocumentType.Image)
            {
                var fileByteArray = fileStream.ToByteArray();
                document.ExternalUrl = await _cloudImageLoader.Load(fileByteArray);
                Console.WriteLine("External URL: {0}", document.ExternalUrl);
            }

            document.InternalUrl = await service.UploadDocument(fileStream);
            Console.WriteLine("Internal URL: {0}", document.InternalUrl);

            return document;
        }
    }

}