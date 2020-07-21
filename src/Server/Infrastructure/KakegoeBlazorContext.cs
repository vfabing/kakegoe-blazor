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
        public DbSet<Author> Authors { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Singer> Singers { get; set; }
        public DbSet<MediaType> MediaTypes { get; set; }
        public DbSet<MediaItem> MediaItems { get; set; }
        public DbSet<MediaVersion> MediaVersions { get; set; }
        public DbSet<MediaVersionSong> MediaVersionSongs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Song>(songBuilder =>
            {
                songBuilder.OwnsOne(s => s.Title);
                songBuilder.Ignore(s => s.Paragraphs);
            });

            modelBuilder.Entity<MediaVersionSong>()
                .HasKey(mvs => new { mvs.MediaVersionId, mvs.SongId});

            modelBuilder.Entity<MediaVersionSong>()
                .HasOne(mvs => mvs.MediaVersion)
                .WithMany(mv => mv.MediaVersionSongs)
                .HasForeignKey(mvs => mvs.MediaVersionId);

            modelBuilder.Entity<MediaVersionSong>()
                .HasOne(mvs => mvs.Song)
                .WithMany(s => s.MediaVersionSongs)
                .HasForeignKey(mvs => mvs.SongId);
        }
    }
}
