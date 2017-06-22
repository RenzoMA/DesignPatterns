using ChainOfResponsibility.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.ConcreteHandler
{
    class EmailSender : Sender
    {
        public EmailSender()
        {
            this.maxAmount = 20000;
        }

        protected override void HandleRequest(double amount)
        {
            Console.WriteLine("Sending via email: S/." + amount.ToString("00.00"));
        }
    }
}
