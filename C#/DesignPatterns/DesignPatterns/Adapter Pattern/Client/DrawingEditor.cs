using System;
using DesignPatterns.AdapterPattern.Interfaces;
using DesignPatterns.AdapterPattern;
using System.Collections.Generic;

namespace DesignPatterns.AdapterPattern.Client
{
    public class DrawingEditor
    {

        List<Shape> shapes;
        public DrawingEditor()
        {
            this.shapes = new List<Shape>();
        }

        public void Add (Shape shape)
        {
            this.shapes.Add(shape);
        }

        public void drawAll()
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
