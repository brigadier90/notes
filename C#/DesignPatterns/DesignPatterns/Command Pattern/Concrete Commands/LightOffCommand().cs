using System;
using DesignPatterns.CommandPattern.Interfaces;
using DesignPatterns.CommandPattern.Receivers;

namespace DesignPatterns.CommandPattern.ConcreteCommands
{
    public class LightOffCommand : ICommand
    {
        public LightBulb LightBulb { get; set; }

        public LightOffCommand(LightBulb LightBulb)
        {
            this.LightBulb = LightBulb;
        }

        public void Execute()
        {
            this.LightBulb.Off();
        }

        public void UnExecute()
        {
            this.LightBulb.On();
        }
    }
}
