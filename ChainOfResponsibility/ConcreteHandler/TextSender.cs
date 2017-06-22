using ChainOfResponsibility.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.ConcreteHandler
{
    class TextSender : Sender
    {
        public TextSender()
        {
            this.maxAmount = 10000;
        }
        protected override void HandleRequest(double amount)
        {
            Console.WriteLine("Sending via SMS: S/." + amount.ToString("00.00"));
        }
    }
}
