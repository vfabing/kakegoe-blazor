using System;
using System.Collections.Generic;
using KakegoeBlazor.Shared.Models.BaseModels;

namespace KakegoeBlazor.Shared.Models
{
    public class MediaItem : BaseJapaneseTextWithTranslations
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
        public int Order { get; set; }

        public int MediaTypeId { get; set; }
        public MediaType MediaType { get; set; }
        public ICollection<MediaVersion> MediaVersions { get; set; }
    }
}
