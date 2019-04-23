using System;
using DesignPatterns.CommandPattern.Interfaces;

namespace DesignPatterns.CommandPattern.Invokers
{
    public class LightBulbRemoteControlInvoker
    {
        ICommand LightOnCommand;
        ICommand LightOffCommand;

        public LightBulbRemoteControlInvoker(ICommand LightOnCommand, ICommand LightOffCommand)
        {
            this.LightOnCommand = LightOnCommand;
            this.LightOffCommand = LightOffCommand;
        }

        public void ClickOn()
        {
            this.LightOnCommand.Execute();
        }

        public void ClickOff()
        {
            this.LightOffCommand.Execute();
        }
    }
}
