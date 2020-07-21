using System.Collections.Generic;

namespace KakegoeBlazor.Shared.Models
{
    public class Song
    {
        public int Id { get; set; }
        public SongTitle Title { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public ICollection<SongParagraph> Paragraphs { get; set; }
        public ICollection<MediaVersionSong> MediaVersionSongs { get; set; }
    }
}
