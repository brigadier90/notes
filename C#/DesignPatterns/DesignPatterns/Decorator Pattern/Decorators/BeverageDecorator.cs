using System;
using DesignPatterns.DecoratorPattern.Components;

namespace DesignPatterns.DecoratorPattern.Decorators
{
    public abstract class BeverageDecorator : ABeverageComponent
    {
        public override abstract double Cost();
    }
}
