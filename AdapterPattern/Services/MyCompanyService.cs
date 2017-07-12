using System;
using System.IO;
using System.Threading.Tasks;

namespace AdapterPattern.Services
{
    public class MyCompanyService
    {
        public async Task<string> UploadDocument(Stream stream)
        {
            await Task.Delay(2000);
            Console.WriteLine("Loading to MyCompanyService");
            var url = $"http://mycompany.com/images/{Guid.NewGuid()}";
            Console.WriteLine("URL {0}", url);
            Console.WriteLine("Loading to MyCompanyService Completed");
            return url;
        }
    }

}