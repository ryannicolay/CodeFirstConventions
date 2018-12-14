using System.Data.Entity;

namespace CodeFirstConventions
{
    partial class Program
    {
        public class VidzyCodeFirstContext : DbContext
        {
            public VidzyCodeFirstContext()
                :base("name=VidzyCodeFirstContext")
            {
            }

            public DbSet<Video> Videos { get; set; }
            public DbSet<Genre> Genres { get; set; }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Genre>()
                            .Property(g => g.Name)
                            .IsRequired()
                            .HasMaxLength(255);

                modelBuilder.Entity<Video>()
                            .Property(v => v.Name)
                            .HasMaxLength(255)
                            .IsRequired();

                modelBuilder.Entity<Video>()
                            .HasRequired(v => v.Genre)
                            .WithMany(g => g.Videos)
                            .HasForeignKey(v => v.GenreId);

                base.OnModelCreating(modelBuilder);
            }
        }
    }
}
