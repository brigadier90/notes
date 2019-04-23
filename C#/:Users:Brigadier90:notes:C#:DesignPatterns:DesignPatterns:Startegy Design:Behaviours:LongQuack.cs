﻿using System;
using DesignPatterns.StartegyDesign.Interfaces;

namespace DesignPatterns.StartegyDesign.Behaviours
{
    public class LongQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("quack quack quack quack quack quack!");
        }
    }
}
