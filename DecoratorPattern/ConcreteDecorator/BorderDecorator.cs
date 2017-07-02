using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

namespace DecoratorPattern.ConcreteDecorator
{
    class BorderDecorator : ControlDecorator
    {
        public BorderDecorator(IControl control) : base(control)
        {
        }

        public override void Draw()
        {
            base.Style = '-';
            base.Draw();
        }
    }
}
