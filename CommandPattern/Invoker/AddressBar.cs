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
        private int current = -1;

        public void Navigate(ICommand command)
        {
            _commands.Add(command);
            command.Execute();
            current++;
        }

        public void GoBack()
        {
            var command = _commands.ElementAtOrDefault(--current);
            if (command != null)
                command.Execute();
            else
                ++current;

        }

        public void GoForward()
        {
            var command = _commands.ElementAtOrDefault(++current);
            if (command == null)
                --current;
            else
                command.Execute();
        }
    }
}

