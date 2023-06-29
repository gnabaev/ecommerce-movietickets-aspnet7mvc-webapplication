using eMovieTickets.Data.Base;
using eMovieTickets.Models;

namespace eMovieTickets.Data.Services
{
    public class MoviesService : EntityBaseRepository<Movie>, IMoviesService
    {
        public MoviesService(AppDbContext context) : base(context)
        {
        }
    }
}
