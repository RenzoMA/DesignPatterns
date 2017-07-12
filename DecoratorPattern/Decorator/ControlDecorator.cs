using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Component;

namespace DecoratorPattern.Decorator
{
    abstract class ControlDecorator : IControl
    {
        private readonly IControl _control;

        protected ControlDecorator(IControl control)
        {
            _control = control;
        }

        public char Style { get; set; }

        public virtual void Draw()
        {
            _control.Style = Style;
            _control.Draw();
        }
    }
}
