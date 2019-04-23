using System;
using DesignPatterns.StatePattern.Context;

namespace DesignPatterns.StatePattern.State
{
    public interface IGateState
    {
        //here we put our actions, events
        void Enter();
        void Pay();
        void PayOK();
        void PayFailed();
    }
}
