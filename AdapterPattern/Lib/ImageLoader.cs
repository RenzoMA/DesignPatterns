using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Lib
{
    class ImageLoader
    {

    }

    interface IImageLoaderAdapter
    {
        void Load(byte[] imageArrayBytes);
    }

    class ImageLoaderAdapter : IImageLoaderAdapter
    {
        public void Load(byte[] imageArrayBytes)
        {
            throw new NotImplementedException();
        }
    }
}
