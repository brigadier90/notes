using System;
using DesignPatterns.StatePattern.Context;

namespace DesignPatterns.StatePattern.State
{
    public class ClosedGateState : IGateState
    {
        Gate Gate;

        public ClosedGateState(Gate Gate)
        {
            this.Gate = Gate;
        }

        public void Enter()
        {
            Console.WriteLine("Cannot Enter While Closed");
        }

        public void Pay()
        {
            Console.WriteLine("Payment being processed");
            this.Gate.State = new ProcessingGateState(this.Gate);
            Console.WriteLine("Current State: Processing");
        }

        public void PayFailed()
        {
            Console.WriteLine("Payment failed");
            Console.WriteLine("Gate Already Closed");
        }

        public void PayOK()
        {
            Console.WriteLine("Processing Skipped");
            Console.WriteLine("Gate Remains Closed");
        }
    }
}
