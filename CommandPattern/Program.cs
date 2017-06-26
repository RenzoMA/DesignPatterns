using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Command;
using CommandPattern.ConcreteCommand;
using CommandPattern.Invoker;
using CommandPattern.Receiver;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Browser browser = new Browser();
            ICommand goBack = new NavigateBack(browser);
            ICommand goForward = new NavigateForward(browser);

            AddressBar addressBar = new AddressBar();



        }
    }
}
