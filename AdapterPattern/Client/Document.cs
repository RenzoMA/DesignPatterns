using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Client
{
    public class Document
    {
        public string InternalUrl { get; set; }
        public string ExternalUrl { get; set; }
    }
}
