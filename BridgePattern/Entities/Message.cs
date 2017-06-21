using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Entities
{
    public class Message
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Content { get; set; }
    }
}
