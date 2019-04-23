using System;
using DesignPatterns.DecoratorPattern.Decorators;
using DesignPatterns.DecoratorPattern.Components;

namespace DesignPatterns.DecoratorPattern.ConcreteDecorators
{
    public class SoyMilk : BeverageDecorator
    {
        ABeverageComponent bc;

        public SoyMilk(ABeverageComponent bc)
        {
            this.bc = bc;
        }

        public override double Cost()
        {
            //extra Soy Milk is $0.50
            return this.bc.Cost() + 0.5;
        }
    }
}
