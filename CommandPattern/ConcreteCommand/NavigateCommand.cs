using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Command;
using CommandPattern.Receiver;

namespace CommandPattern.ConcreteCommand
{
    class NavigateCommand : ICommand
    {
        private readonly Browser _browser;
        private readonly string _url;
        public NavigateCommand(Browser browser, string url)
        {
            _browser = browser;
            _url = url;
        }

        public void Execute()
        {
            _browser.DisplayNewPage(_url);
        }
    }
}
