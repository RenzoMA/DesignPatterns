using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

namespace DecoratorPattern.ConcreteDecorator
{
    class LabelDecorator : ControlDecorator
    {
        private string _label;
        public LabelDecorator(IControl control, string label) : base(control)
        {
            _label = label;
        }

        private void DrawLabel()
        {
            Console.WriteLine($"-> {_label}");
        }

        public override void Draw()
        {
            base.Draw();
            DrawLabel();
        }
    }
}
