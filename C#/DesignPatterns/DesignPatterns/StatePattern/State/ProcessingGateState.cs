using System;
using DesignPatterns.StatePattern.Context;

namespace DesignPatterns.StatePattern.State
{
    public class ProcessingGateState : IGateState
    {
        private Gate Gate;

        public ProcessingGateState(Gate Gate)
        {
            this.Gate = Gate;
        }

        public void Enter()
        {
            Console.WriteLine("Cannot Enter While Processing");
        }

        public void Pay()
        {
            Console.WriteLine("Payment already in process");
        }

        public void PayFailed()
        {
            Console.WriteLine("Payment failed");
            this.Gate.State = new ClosedGateState(this.Gate);
            Console.WriteLine("Current State: Closed");
        }

        public void PayOK()
        {
            Console.WriteLine("Payment succeeded");
            this.Gate.State = new OpenGateState(this.Gate);
            Console.WriteLine("Current State: Open");
        }
    }
}
