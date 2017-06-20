using AdapterPattern.Client;
using AdapterPattern.Helpers;
using AdapterPattern.Library;
using System;
using System.IO;
using System.Threading.Tasks;

namespace AdapterPattern.Adapter
{
    class FileAdapter : CloudImageLoader, IFileAdapter
    {
        public async Task<Document> Upload(Stream fileStream, DocumentType documentType)
        {
            var service = new MyCompanyService();
            var document = new Document();

            Console.WriteLine("----- Upload has started -----");
            Console.WriteLine(String.Format("----- DocumentType: {0} -----", documentType.ToString()));

            if (documentType == DocumentType.Image)
            {
                var fileByteArray = fileStream.ToByteArray();
                document.ExternalUrl = await base.Load(fileByteArray);
                Console.WriteLine(String.Format("External URL: {0}", document.ExternalUrl));
            }

            document.InternalUrl = await service.UploadDocument(fileStream);
            Console.WriteLine(String.Format("Internal URL: {0}", document.InternalUrl));

            return document;
        }
    }

    public class MyCompanyService
    {
        public async Task<string> UploadDocument(Stream stream)
        {
            await Task.Delay(2000);
            return $"http://mycompany.com/images/{Guid.NewGuid()}";
        }
    }

}