using System;
namespace DesignPatterns.BridgePattern
{
    public class Album
    {
        public string Name { get; set; }
        public string Cover { get; set; }
        public string BandWebsite { get; set; }
        public string MainSong { get; set; }

        public Album(string Name, string Cover, string BandWebsite, string MainSong)
        {
            this.Name = Name;
            this.Cover = Cover;
            this.BandWebsite = BandWebsite;
            this.MainSong = MainSong;

        }
    }
}
