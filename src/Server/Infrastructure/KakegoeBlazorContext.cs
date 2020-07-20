using KakegoeBlazor.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace KakegoeBlazor.Server.Infrastructure
{
    public class KakegoeBlazorContext : DbContext
    {
        public KakegoeBlazorContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Song> Songs { get; set; }
    }
}
