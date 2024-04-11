using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoroCassette.Domain.Model
{
    public class Cassette
    {
        public int Id { get; set; }
        public string MovieTitle { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int MovieLength { get; set; }
        public Director DirectorOfMovie { get; set; }
        public Genre GenreOfMovie { get; set; }
        public bool Availability { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
    }
}
