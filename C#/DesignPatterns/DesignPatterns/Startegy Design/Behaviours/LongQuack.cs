using System;
using DesignPatterns.StartegyDesign.Interfaces;

namespace DesignPatterns.StartegyDesign.Behaviours
{
    public class Longquack : IQuackBehaviour
    {
        public Longquack()
        {
        }

        public void Quack()
        {
            Console.WriteLine("quack quack quack quack quack quack quack quack quack quack!");
        }
    }
}
