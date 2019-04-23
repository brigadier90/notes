using System;

namespace DesignPatterns.CommandPattern.Receivers
{
    public class LightBulb
    {
        public void On()
        {
            Console.WriteLine("The light has been turned on");
        }

        public void Off()
        {
            Console.WriteLine("The light has been turned off");
        }
    }
}
