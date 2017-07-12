using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Component
{
    abstract class SystemElement
    {
        public string Name { get; set; }
        protected ConsoleColor DefaultColor { get; set; }
        public abstract void Display(int separator);
        

    }
}
