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
        public static IEnumerable<string> Urls()
        {
            yield return "http://www.google.com";
            yield return "http://www.microsoft.com";
            yield return "http://www.visualstudio.com";
            yield return "http://www.github.com";
            yield return "http://www.commands.com";
            yield return "http://www.apple.com";
        }
        static void Main(string[] args)
        {
            NewBrowser browser = new NewBrowser();
            AddressBar addressBar = new AddressBar();
            foreach (string url in Urls())
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
