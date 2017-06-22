using ChainOfResponsibility.ConcreteHandler;
using ChainOfResponsibility.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Sender sender = Setup();
            double[] amounts = { 1000, 20000, 10000, 15000, 25000, 50000, 60000 };
            foreach (double amount in amounts)
            {
                sender.Send(amount);
            }
            Console.ReadKey();
        }

        static Sender Setup()
        {
            return new TextSender()
                    .SetNext(new EmailSender())
                    .SetNext(new FileSender());
        }


    }
}
