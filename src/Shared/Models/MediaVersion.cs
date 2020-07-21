using System.Collections.Generic;

namespace KakegoeBlazor.Shared.Models
{
    public class MediaVersion
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Serial { get; set; }

        public ICollection<MediaVersionSong> MediaVersionSongs { get; set; }
    }
}
