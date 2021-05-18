using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using MoviesApp.EFModels;

namespace MoviesApp.DAL
{
    public class MovieRepository : IMovieRepository
    {
        private moviesDBContext context;

        public MovieRepository()
        {
            this.context = new moviesDBContext();
        }

        public IEnumerable<Movie> GetMovies(string phrase)
        {
            //ne valja al nema veze sad
            return context.Movies.ToList();
            
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
