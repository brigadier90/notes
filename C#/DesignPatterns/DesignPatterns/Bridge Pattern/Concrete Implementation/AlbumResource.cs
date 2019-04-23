using System;
using DesignPatterns.BridgePattern.Implementation;

namespace DesignPatterns.BridgePattern.ConcreteImplementation
{
    public class AlbumResource : IResource
    {
        private Album Album;
        public AlbumResource(Album a)
        {
            this.Album = a;
        }

        public string Image()
        {
            return this.Album.Cover;
        }

        public string Snippet()
        {
            return this.Album.MainSong;
        }

        public string Title()
        {
            return this.Album.Name;
        }

        public string Url()
        {
            return this.Album.BandWebsite;
        }
    }
}
