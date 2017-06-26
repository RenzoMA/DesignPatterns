using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Command;
using CommandPattern.Receiver;

namespace CommandPattern.ConcreteCommand
{
    class NavigateBack : ICommand
    {
        private readonly Browser _browser;
        public NavigateBack(Browser browser)
        {
            _browser = browser;
        }

        public void Execute()
        {
            _browser.GoBack();
        }
    }
}
