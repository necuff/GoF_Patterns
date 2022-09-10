using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Components
{
    class Switch
    {
        private Dictionary<String, Command> commandMap = new Dictionary<string, Command>();

        public void Register(String commandName, Command command)
        {
            commandMap.Add(commandName, command);
        }

        public void Execute(String commandName)
        {
            Command command = commandMap.GetValueOrDefault(commandName);

            if(command == null)
            {
                throw new NullReferenceException();
            }
            command.Execute();
        }
    }
}
