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
    class Browser
    {
        public AddressBar AddressBar { get;}
        public Browser()
        {
            AddressBar = new AddressBar();
        }
        public void DisplayNewPage(string url)
        {
            Console.WriteLine(url);
        }
        public void Navigate(ICommand command)
        {
            AddressBar.Navigate(command);
        }

        public void GoBack()
        {
            AddressBar.GoBack();
        }
        public void GoForward()
        {
            AddressBar.GoForward();
        }
    }
}
