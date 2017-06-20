using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdapterPattern.Library
{
    class CloudImageLoader
    {
        protected virtual async Task<string> Load(byte[] imageArrayBytes)
        {
            await Task.Delay(2000);
            var url = $"http://cloud.com/images/{Guid.NewGuid()}";
            return url;
        }
    }
}
    
