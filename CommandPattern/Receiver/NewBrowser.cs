using CommandPattern.Command;
using CommandPattern.ConcreteCommand;
using CommandPattern.Invoker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Receiver
{
    class NewBrowser : GenericBrowser
    {
        public override void Navigate(string url)
        {
            Console.WriteLine(url);
        }
    }
}
