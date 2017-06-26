using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Command;

namespace CommandPattern.Invoker
{
    class AddressBar
    {
        private List<ICommand> _commands = new List<ICommand>();

        public void Navigate(ICommand command)
        {
            _commands.Add(command);
            command.Execute();
        }
    }
}

