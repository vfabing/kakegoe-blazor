using System.Collections.Generic;

namespace KakegoeBlazor.Shared.Models
{
    public class SongParagraph
    {
        public ICollection<SongLine> Lines { get; set; }
    }
}
