using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW18
{
    public class Sender
    {
        Command? _command;
        public void SetCommand(Command command)
        {
            _command = command;
        }
        public async Task Execute()
        {
            await _command.Execute();
        }
    }
}
