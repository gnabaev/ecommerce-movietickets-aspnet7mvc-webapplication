using eMovieTickets.Data.Base;
using eMovieTickets.Models;

namespace eMovieTickets.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
    }
}
