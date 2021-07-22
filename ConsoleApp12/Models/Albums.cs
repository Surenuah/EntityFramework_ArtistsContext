using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Models
{
    public class Albums
    {
        public int AlbumId { get; set; }
        public int ArtistId { get; set; }
        public string AlbumTitle { get; set; }
        public DateTime AlbumYear { get; set; }
        public string AlbumTracks { get; set; }
    }
}
