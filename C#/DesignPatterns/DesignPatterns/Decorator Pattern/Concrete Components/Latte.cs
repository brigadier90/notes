using System;
using DesignPatterns.DecoratorPattern.Components;

namespace DesignPatterns.DecoratorPattern.ConcreteComponents
{
    public class Latte : ABeverageComponent
    {

        public override double Cost()
        {
            //a Latte without any condements costs $1.00
            return 1;
        }
    }
}
