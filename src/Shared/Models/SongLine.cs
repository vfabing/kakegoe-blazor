using System.Collections.Generic;

namespace KakegoeBlazor.Shared.Models
{
    public class SongLine
    {
        public ICollection<SongLinePart> Parts { get; set; }
    }
}
