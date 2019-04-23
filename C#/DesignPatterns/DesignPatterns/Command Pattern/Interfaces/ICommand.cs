using System;
using DesignPatterns.CommandPattern.Receivers;

namespace DesignPatterns.CommandPattern.Interfaces
{
    public interface ICommand
    {

        void Execute();
        void UnExecute();

    }
}
