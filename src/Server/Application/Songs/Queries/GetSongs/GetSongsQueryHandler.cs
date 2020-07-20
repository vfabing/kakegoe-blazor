using System.Collections.Generic;
using System.Threading.Tasks;
using KakegoeBlazor.Server.Infrastructure;
using KakegoeBlazor.Shared.Models;

namespace KakegoeBlazor.Server.Application.Songs.Queries.GetSongs
{
    public class GetSongsQuery { }

    public class GetSongsQueryHandler : BaseHandler<GetSongsQuery, IEnumerable<Song>>
    {

        public GetSongsQueryHandler(KakegoeBlazorContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<Song>> HandleAsync(GetSongsQuery query)
        {
            return await Task.FromResult(new List<Song>()
            {
                new Song { Title = "Song 1" },
                new Song { Title = "Song 2" },
                new Song { Title = "Song 3" },
            });
        }
    }
}
