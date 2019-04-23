using System;
using DesignPatterns.BridgePattern.Implementation;

namespace DesignPatterns.BridgePattern.ConcreteImplementation
{
    public class BookResource : IResource
    {
        private Book Book;
        public BookResource(Book b)
        {
            this.Book = b;
        }

        public string Image()
        {
            return this.Book.Image;
        }

        public string Snippet()
        {
            return this.Book.Excerpt;
        }  

        public string Title()
        {   
            return this.Book.Name;
        }

        public string Url()
        {
            return this.Book.Url;
        }
    }
}
