using System;
using DesignPatterns.CommandPattern.Interfaces;
using DesignPatterns.CommandPattern.Receivers;

namespace DesignPatterns.CommandPattern.ConcreteCommands
{
    public class LightOnCommand : ICommand
    {
        public LightBulb LightBulb { get; set; }

        public LightOnCommand(LightBulb LightBulb)
        {
            this.LightBulb = LightBulb;
        }

        public void Execute()
        {
            this.LightBulb.On();
        }

        public void UnExecute()
        {
            this.LightBulb.Off();
        }
    }
}
