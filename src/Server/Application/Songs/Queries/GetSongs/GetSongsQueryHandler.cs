using System.Collections.Generic;
using System.Threading.Tasks;
using KakegoeBlazor.Server.Infrastructure;
using KakegoeBlazor.Shared.Models;
using Microsoft.EntityFrameworkCore;

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
            return await Context.Songs.ToListAsync();
        }
    }
}
