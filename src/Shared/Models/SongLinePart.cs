using System.Collections.Generic;
using KakegoeBlazor.Shared.Models.BaseModels;

namespace KakegoeBlazor.Shared.Models
{
    public class SongLinePart : BaseJapaneseTextWithTranslations
    {
        public ICollection<Singer> Singers { get; set; }

        public string Kakegoe { get; set; }

        public string Furicopi { get; set; }
    }
}
