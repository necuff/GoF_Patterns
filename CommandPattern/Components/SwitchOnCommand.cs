using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Components
{
    class SwitchOnCommand : Command
    {
        private Light light;

        public SwitchOnCommand(Light light)
        {
            this.light = light;
        }   

        public void Execute()
        {
            light.TurnOn();
        }
    }
}
