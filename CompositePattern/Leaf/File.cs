using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositePattern.Component;

namespace CompositePattern.Leaf
{
    class File : SystemElement
    {
        public File()
        {
            DefaultColor = ConsoleColor.Blue; 
        }

        public override void Display(int n)
        {
            string formattedName = new string('-', n) + Name;
            Console.ForegroundColor = DefaultColor;
            Console.WriteLine(formattedName);
        }
    }
}
