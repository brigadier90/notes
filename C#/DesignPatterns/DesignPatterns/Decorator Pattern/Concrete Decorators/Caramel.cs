using System;
using DesignPatterns.DecoratorPattern.Decorators;
using DesignPatterns.DecoratorPattern.Components;

namespace DesignPatterns.DecoratorPattern.ConcreteDecorators
{
    public class Caramel : BeverageDecorator
    {
        ABeverageComponent bc;

        public Caramel(ABeverageComponent bc)
        {
            this.bc = bc;
        }

        public override double Cost()
        {
            //extra Caramael is $1
            return this.bc.Cost() + 1;
        }
    }
}
