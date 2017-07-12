using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Component;
using DecoratorPattern.ConcreteComponent;
using DecoratorPattern.ConcreteDecorator;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IControl control = new Button();
            control.Draw();
            Console.ReadKey(true);
            LabelDecorator labelDecorator = new LabelDecorator(control,"Click me");
            BorderDecorator borderDecorator = new BorderDecorator(labelDecorator);
            borderDecorator.Draw();
            Console.ReadKey(true);
        }
    }
}
