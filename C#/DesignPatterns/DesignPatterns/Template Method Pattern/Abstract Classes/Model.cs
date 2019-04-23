using System;
namespace DesignPatterns.TemplateMethodPattern.AbstractClasses
{
    public abstract class Model
    {
        public void Save()
        {
            Console.WriteLine("preparing SQL");
            Operation1();
            Console.WriteLine("object saved locally");
            Operation2();
            Console.WriteLine("Object commited to DB");
        }

        public abstract void Operation1();
        public abstract void Operation2();
    }
}
