using System;
using DesignPatterns.StartegyDesign.Interfaces;

namespace DesignPatterns.StartegyDesign.Behaviours
{
    public class LoudQuack : IQuackBehaviour
    {
        public LoudQuack()
        {
        }

        public void Quack()
        {
            Console.WriteLine("QUACK!");
        }
    }
}
