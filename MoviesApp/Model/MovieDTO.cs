using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.Model
{
    public class MovieDTO
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string cover { get; set; }
        public string release { get; set; }
        public string cast { get; set; }
        public int rating { get; set; }
        public string category { get; set; }

        public MovieDTO(int id, string title, string description, string cover, string release, string cast, int rating, string category)
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.cover = cover;
            this.release = release;
            this.cast = cast;
            this.rating = rating;
            this.category = category;
        }
    }
}
