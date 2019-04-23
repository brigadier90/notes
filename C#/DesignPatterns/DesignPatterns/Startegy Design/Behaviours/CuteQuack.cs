using System;
using DesignPatterns.StartegyDesign.Interfaces;

namespace DesignPatterns.StartegyDesign.Behaviours
{
    public class CuteQuack : IQuackBehaviour
    {
        public CuteQuack()
        {
        }

        public void Quack()
        {
            Console.WriteLine("quack quack! :) ");
        }
    }
}
