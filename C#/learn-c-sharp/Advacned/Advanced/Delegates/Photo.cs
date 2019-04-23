using System;
namespace Advanced.Delegates
{
    public class Photo
    {
        public Photo()
        {

        }

        public void save()
        {
            Console.WriteLine("Photo saved");
        }


        public static Photo Load(string path)
        {
            return new Photo();
        }
    }
}
