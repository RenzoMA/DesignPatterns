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
        private string baseUrl = "http://cloud.com/images";
        protected virtual async Task<string> Load(byte[] imageArrayBytes)
        {
            await Task.Delay(2000);
            var url = $"{baseUrl}/{Guid.NewGuid()}";
            return url;
        }
    }
}
    
