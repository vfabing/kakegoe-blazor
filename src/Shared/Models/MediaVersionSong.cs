namespace KakegoeBlazor.Shared.Models
{
    public class MediaVersionSong
    {
        public int TrackOrder { get; set; }

        public int SongId { get; set; }
        public Song Song { get; set; }
        public int MediaVersionId { get; set; }
        public MediaVersion MediaVersion { get; set; }
    }
}
