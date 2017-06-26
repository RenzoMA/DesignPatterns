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
            ICommand navigateCommand = new NavigateCommand(browser, "http://google.com.pe");
            browser.Navigate(navigateCommand);
            ICommand navigateCommand1 = new NavigateCommand(browser, "http://microsoft.come");
            browser.Navigate(navigateCommand1);
            ICommand navigateCommand2 = new NavigateCommand(browser, "http://apple.co");
            browser.Navigate(navigateCommand2);
            ICommand navigateCommand3 = new NavigateCommand(browser, "http://linux.com");
            browser.Navigate(navigateCommand3);


            while (true)
            {
                string action = Console.ReadLine();
                if (action == "back")
                {
                    browser.GoBack();
                }
                else if(action == "forward")
                {
                    browser.GoForward();
                }
            }
        }
    }
}
