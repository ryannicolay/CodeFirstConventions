using System;
using System.Collections.Generic;

namespace CodeFirstConventions
{

    public class Video
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public virtual Genre Genre { get; set; }
        public int GenreId { get; set; }
        public Classification Classification { get; set; }
    }
}
