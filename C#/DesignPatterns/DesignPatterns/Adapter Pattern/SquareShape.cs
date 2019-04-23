using System;
using DesignPatterns.AdapterPattern.Interfaces;

namespace DesignPatterns.AdapterPattern
{
    public class SquareShape : Shape
    {
        public void Draw()
        {
            Console.WriteLine("A Sqaure has just been drawn!");
        }
    }
}
