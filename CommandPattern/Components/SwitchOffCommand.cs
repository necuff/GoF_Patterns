using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Components
{
    class SwitchOffCommand : Command
    {
        private Light light;

        public SwitchOffCommand(Light light)
        {
            this.light = light;
        }   

        public void Execute()
        {
            light.TurnOff();
        }
    }
}
