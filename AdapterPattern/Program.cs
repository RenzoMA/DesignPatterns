using AdapterPattern.Adapter;
using AdapterPattern.Entities;
using AdapterPattern.Library;
using System;
using System.IO;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            InvokeOldClient();
            InvokeNewClient();
        }
        static void InvokeNewClient()
        {
            Console.WriteLine("");
            Console.WriteLine("-- NEW CLIENT --");
            Stream stream = new MemoryStream(100);
            IFile imageFileAdapter = new FileAdapter();
            var result = imageFileAdapter.Upload(stream, DocumentType.Image).Result;
            Console.ReadKey();

        }
        static void InvokeOldClient()
        {
            Console.WriteLine("-- OLD CLIENT --");
            byte[] imageArray = new byte[1200];
            CloudImageLoader imageLoader = new CloudImageLoader();
            var result = imageLoader.Load(imageArray).Result;
            Console.ReadKey();
        }
    }
}
