using System;
using DesignPatterns.AdapterPattern.Interfaces;

namespace DesignPatterns.AdapterPattern
{
    public class TextShapeAdapter : Shape
    {
        TextView tv;

        public TextShapeAdapter(TextView tv)
        {
            this.tv = tv;
        }
        public void Draw()
        {
            tv.display();
        }
    }
}
