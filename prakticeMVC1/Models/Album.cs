using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace prakticeMVC1.Models
{
    public class Album
    {
        public int AlbumId { get; set; }

        [ Display (Name = "Genre") ]
        public int GenreId { get; set; }

        [Display (Name = "Artist")]
        public int ArtistId { get; set; }
        public decimal Price { get; set; }
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public Artist Artist { get; set; }
    }
}
