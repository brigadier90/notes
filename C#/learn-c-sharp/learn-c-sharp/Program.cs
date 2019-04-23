using System;
using learncsharp.lazy;

namespace learncsharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Point[] points = { new Point(3,4), new Point(5,4)};

            foreach (Point p in points)
            {
                Console.WriteLine(p.toString());
            }

            Lazy.print("Hello from lazy");


        }


        public class Point
        {
            public int x, y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public string toString()
            {
               return "x: " + x + ", y: " + y;
            }
        }

        public class Point3D : Point
        {
            public int z;

            public Point3D(int x, int y, int z) : 
                base(x, y)
            {
                this.z = z;
            }
        }
    }
}
