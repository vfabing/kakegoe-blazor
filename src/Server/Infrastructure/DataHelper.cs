using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using KakegoeBlazor.Shared.Models;

namespace KakegoeBlazor.Server.Infrastructure
{
    public static class DataHelper
    {
        public static async Task SeedAsync(KakegoeBlazorContext context)
        {
            // TODO: Add a system to init the database from a Json file, specified by configuration.

            context.MediaTypes.AddRange(
                new MediaType { Id = 1, Name = "Single" },
                new MediaType { Id = 2, Name = "Album" },
                new MediaType { Id = 3, Name = "DVD/Blu-ray" },
                new MediaType { Id = 4, Name = "Others" });

            context.Groups.Add(new Group { Id = 1, Kanji = "グレートシンガー", Romaji = "gureeto shingaa" });
            context.Authors.Add(new Author { Id = 1, Kanji = "グレート作曲", Romaji = "gureeto sakkyoku" });

            context.Add(new MediaItem
            {
                Id = 1,
                EN = "My Super Single",
                Kanji = "スーパーシングル",
                Romaji = "Suupaa shinguru",
                Date = new DateTime(2012, 08, 29),
                ImageUrl = "https://mywebsite/assets/mysuperimage.png",
                Order = 1,
                MediaTypeId = 1,
                MediaVersions = new List<MediaVersion>
                {
                    new MediaVersion { Id = 1, Name = "Limited Edition A", Serial = "ABCD1-2020", ImageUrl = "https://mywebsite/assets/mysuperimage.png" },
                    new MediaVersion { Id = 2, Name = "Limited Edition B", Serial = "ABCD2-2020", ImageUrl = "https://mywebsite/assets/mysuperimage.png" },
                }
            });

            context.AddRange(
                new MediaVersionSong {
                    MediaVersionId = 1,
                    TrackOrder = 1,
                    Song = new Song
                    {
                        Id = 1,
                        Title = new SongTitle { EN = "Song 1", Kanji = "曲1", Romaji = "kyoku ichi" },
                        AuthorId = 1,
                        GroupId = 1
                    }
                },
                new MediaVersionSong
                {
                    MediaVersionId = 1,
                    TrackOrder = 2,
                    Song = new Song
                    {
                        Id = 2,
                        Title = new SongTitle { EN = "Song 2", Kanji = "曲2", Romaji = "kyoku ni" },
                        AuthorId = 1,
                        GroupId = 1
                    }
                },
                new MediaVersionSong
                {
                    MediaVersionId = 1,
                    TrackOrder = 3,
                    Song = new Song
                    {
                        Id = 3,
                        Title = new SongTitle { EN = "Song 3", Kanji = "曲3", Romaji = "kyoku san" },
                        AuthorId = 1,
                        GroupId = 1
                    }
                });

            await context.SaveChangesAsync();
        }
    }
}
