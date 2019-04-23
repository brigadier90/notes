using System;
using DesignPatterns.StatePattern.Context;

namespace DesignPatterns.StatePattern.State
{
    public class OpenGateState : IGateState
    {
        Gate Gate;

        public OpenGateState(Gate Gate)
        {
            this.Gate = Gate;
        }

        public void Enter()
        {
            Console.WriteLine("Customer Has Entered");
            this.Gate.State = new ClosedGateState(this.Gate);
            Console.WriteLine("Current State: Closed");
        }

        public void Pay()
        {
            Console.WriteLine("Gate Already Open");
        }

        public void PayFailed()
        {
            Console.WriteLine("Payment failed");
            this.Gate.State = new ClosedGateState(this.Gate);
            Console.WriteLine("Current State: Closed");
        }

        public void PayOK()
        {
            Console.WriteLine("Payment Accepted");
            Console.WriteLine("Gate Already Opened");
        }
    }
}
