using System;
using DesignPatterns.DecoratorPattern.Components;

namespace DesignPatterns.DecoratorPattern.ConcreteComponents
{
    public class Espresso : ABeverageComponent
    {

        public override double Cost()
        {
            //an espresso without any condements costs $1.50
            return 1.5;
        }
    }
}
