using System;

namespace Advanced.Delegates
{
    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);

        public void Process(string path, Action<Photo> photoFilterHandler)
        {
            var photo = Photo.Load(path);

            var filters = new PhotoFilters();

            //not flexible
            //filters.ApplyBrightness(photo);
            //filters.ApplyContrast(photo);
            //filters.Resize(photo);
            //photo.save();

            //using delegate user can specify whih function to call
            photoFilterHandler(photo);

            //can also use 
            //System.Action<Photo> action; returns void
            //System.Func<string, Photo> handler; returns something
        }
    }
}
