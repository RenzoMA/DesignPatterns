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
        private static List<string> urls = new List<string>()
        {
            "http://www.google.com",
            "http://www.microsoft.com",
            "http://www.visualstudio.com",
            "http://www.github.com",
            "http://www.commands.com",
            "http://www.apple.com",
        };
        static void Main(string[] args)
        {
            NewBrowser browser = new NewBrowser();
            AddressBar addressBar = new AddressBar();
            foreach (string url in urls)
            {
                ICommand command = new NavigateCommand(browser, url);
                addressBar.Navigate(command);
            }
            
            while (true)
            {
                string action = Console.ReadLine();
                if (action == "back")
                {
                    addressBar.GoBack();
                }
                else if(action == "forward")
                {
                    addressBar.GoForward();
                }
            }
        }
    }
}
