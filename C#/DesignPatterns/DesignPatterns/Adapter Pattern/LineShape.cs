using System;
using DesignPatterns.AdapterPattern.Interfaces;

namespace DesignPatterns.AdapterPattern
{
    public class LineShape : Shape
    {
        public void Draw()
        {
            Console.WriteLine("A Line has just been drawn!");
        }
    }
}
