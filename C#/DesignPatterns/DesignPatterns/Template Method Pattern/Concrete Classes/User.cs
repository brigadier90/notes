using System;
using DesignPatterns.TemplateMethodPattern.AbstractClasses;

namespace DesignPatterns.TemplateMethodPattern.ConcreteClasses
{
    public class User : Model
    {

        public override void Operation1()
        {
            Console.WriteLine("op1: validate user data");
        }

        public override void Operation2()
        {
            Console.WriteLine("op2: Log User Activity");
        }
    }
}
