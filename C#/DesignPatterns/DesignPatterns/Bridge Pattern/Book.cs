using System;
namespace DesignPatterns.BridgePattern
{
    public class Book
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Url { get; set; }
        public string Excerpt { get; set; }

        public Book(string Name, string Image, string Url, string Excerpt)
        {
            this.Name = Name;
            this.Image = Image;
            this.Url = Url;
            this.Excerpt = Excerpt;

        }
    }
}
