using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Command;
using CommandPattern.Receiver;

namespace CommandPattern.ConcreteCommand
{
    class NavigateForward : ICommand
    {
        private readonly Browser _browser;

        public NavigateForward(Browser browser)
        {
            _browser = browser;
        }

        public void Execute()
        {
            _browser.GoForward();
        }
    }
}
