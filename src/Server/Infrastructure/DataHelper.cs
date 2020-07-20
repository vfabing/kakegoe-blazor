using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KakegoeBlazor.Shared.Models;

namespace KakegoeBlazor.Server.Infrastructure
{
    public static class DataHelper
    {
        public static async Task SeedAsync(KakegoeBlazorContext context)
        {
            context.Songs.AddRange(
                   new Song { Id = 1, Title = "Song 1" },
                   new Song { Id = 2, Title = "Song 2" },
                   new Song { Id = 3, Title = "Song 3" });

            await context.SaveChangesAsync();
        }
    }
}
