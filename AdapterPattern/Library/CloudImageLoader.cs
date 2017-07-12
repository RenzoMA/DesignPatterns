using System;
using System.Threading.Tasks;

namespace AdapterPattern.Library
{
    /// <summary>
    /// Adaptee
    /// </summary>
    class CloudImageLoader
    {
        private string baseUrl = "http://cloud.com/images";
        public async Task<string> Load(byte[] imageArrayBytes)
        {
            Console.WriteLine("Loading to CloudImage");
            await Task.Delay(2000);
            var url = $"{baseUrl}/{Guid.NewGuid()}";
            Console.WriteLine("URL {0}",url);
            Console.WriteLine("Loading to CloudImage Completed");
            return url;
        }
    }
}
    
