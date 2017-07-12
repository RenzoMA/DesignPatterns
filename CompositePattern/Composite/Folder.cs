using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositePattern.Component;

namespace CompositePattern.Composite
{
    class Folder : SystemElement
    {
        public List<SystemElement> Elements;
        private readonly int _defaultSeparatorLength;
        private readonly int _defaultSeparatorStart;

        public Folder()
        {
            Elements = new List<SystemElement>();
            _defaultSeparatorLength = 2;
            _defaultSeparatorStart = 0;
            DefaultColor = ConsoleColor.Green;
        }

        public void DisplayAll()
        {
            Display(_defaultSeparatorStart);
        }

        public void AddElement(SystemElement element)
        {
            Elements.Add(element);
        }

        public override void Display(int separator)
        {
            String formattedName = new string('-', separator) + Name;
            Console.ForegroundColor = DefaultColor;
            Console.WriteLine(formattedName);
            separator += _defaultSeparatorLength;
            foreach (SystemElement element in Elements)
            {
                element.Display(separator);
            }
        }
    }
}
