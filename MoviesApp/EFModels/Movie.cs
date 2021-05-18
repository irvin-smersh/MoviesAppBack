using System;
using System.Collections.Generic;

#nullable disable

namespace MoviesApp.EFModels
{
    public partial class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public byte[] Cover { get; set; }
        public DateTime Release { get; set; }
        public string Cast { get; set; }
        public int Rating { get; set; }
        public string Category { get; set; }
    }
}
