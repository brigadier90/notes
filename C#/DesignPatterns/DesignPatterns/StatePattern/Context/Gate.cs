using System;
using DesignPatterns.StatePattern.State;

namespace DesignPatterns.StatePattern.Context
{
    public class Gate
    {
        public IGateState State { get; set; }

        public Gate() { 
        }

        public Gate(IGateState state)
        {
            this.State = state;
        }

        public void Enter()
        {
            this.State.Enter();
        }

        public void Pay()
        {
            this.State.Pay();
        }

        public void PayOK()
        {
            this.State.PayOK();
        }

        public void PayFailed()
        {
            this.State.PayFailed();
        }
    }
}
