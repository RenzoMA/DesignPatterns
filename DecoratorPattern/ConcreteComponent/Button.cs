using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Component;

namespace DecoratorPattern.ConcreteComponent
{
    class Button : IControl
    {
        public char Style { get; set; }

        public Button()
        {
            Style = '*';
        }

        public void Draw()
        {
            int size = 21;
            Console.WriteLine(new string(Style, size));
            for (int i = 0; i < size - 15; i++)
            {
                if (i == 2)
                    Console.WriteLine(Style + new string(' ', size - 18) + "Funny Button" + new string(' ', size - 17) +
                                      Style);
                else
                    Console.WriteLine(Style + new string(' ', size - 2) + Style);
            }
            Console.WriteLine(new string(Style, size));
        }
    }
}
