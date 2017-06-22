using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handler
{
    public abstract class Sender
    {
        protected Sender nextSender;
        protected double maxAmount;
        public Sender SetNext(Sender sender)
        {
            if (nextSender == null)
            {
                this.nextSender = sender;
            }
            else
            {
                nextSender.SetNext(sender);
            }
            return this;
        }
        public void Send(double amount)
        {
            if (amount <= maxAmount)
            {
                HandleRequest(amount);
            }
            else if (nextSender != null)
            {
                nextSender.Send(amount);
            }
            else
            {
                Console.WriteLine("Unhandled!!! S/." + amount.ToString("00.00"));
            }
        }
        abstract protected void HandleRequest(double amount);
    }
}
