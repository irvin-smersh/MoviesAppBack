using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoviesApp.EFModels;

namespace MoviesApp.DAL
{
    public interface IMovieRepository : IDisposable
    {
        IEnumerable<Movie> GetMovies(string phrase);
    }
}
