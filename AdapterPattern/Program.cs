using AdapterPattern.Adapter;
using AdapterPattern.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IFileAdapter imageFileAdapter = new FileAdapter();
            Stream stream = new MemoryStream(100);
            FileManager fileManager = new FileManager(imageFileAdapter, DocumentType.Image);
            var result = fileManager.Save(stream).Result;
            Console.ReadKey();
        }
    }
}
