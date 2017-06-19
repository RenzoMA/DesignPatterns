using System;
using System.IO;

namespace AdapterPattern.Lib
{
    class ImageFileAdapter : IFileAdapter
    {
        public string Upload(Stream fileStream)
        {
            return $"http://images/{new Guid()}";
        }
    }
}