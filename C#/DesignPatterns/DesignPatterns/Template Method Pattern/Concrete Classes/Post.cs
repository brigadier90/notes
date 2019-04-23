using System;
using DesignPatterns.TemplateMethodPattern.AbstractClasses;

namespace DesignPatterns.TemplateMethodPattern.ConcreteClasses
{
    public class Post : Model
    {

        public override void Operation1()
        {
            Console.WriteLine("op1: check user who is posting's access rights");
        }

        public override void Operation2()
        {
            Console.WriteLine("op2: Log Post Activity");
        }
    }
}
