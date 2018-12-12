using System.Data.Entity;

namespace CodeFirstDesign
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
        }
    }
}
