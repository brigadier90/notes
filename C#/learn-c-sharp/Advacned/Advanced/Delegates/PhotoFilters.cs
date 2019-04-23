using System;
namespace Advanced.Delegates
{
    public class PhotoFilters
    {
        public PhotoFilters()
        {
        }

        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Brightness applied");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Contrast applied");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Photo resized");
        }
    }
}
